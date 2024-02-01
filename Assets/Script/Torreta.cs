using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Torreta : MonoBehaviour
{
    int NumBalas;
    bool detectadoEnemigo;
    float cooldown;
    public GameObject bala;
    GameObject balaClon;
    public Transform spawn;
    Transform enemigo;
    // Start is called before the first frame update
    void Start()
    {
        detectadoEnemigo = false;
        NumBalas = 10;   
    }

    // Update is called once per frame
    void Update()
    {
        int mascara = 1 << 6;

        Collider[] detectado = Physics.OverlapSphere(transform.position, 2.5f, mascara);

        if(detectado.Length > 0)
        {
            enemigo = detectado[0].transform;
            transform.LookAt(detectado[0].transform.position);
                        
            detectadoEnemigo = true;
            
            if (detectadoEnemigo == true)
            {
                cooldown += Time.deltaTime;
                if (cooldown > 1) 
                {
                    NumBalas--;
                    cooldown = 0;
                    balaClon = Instantiate(bala, spawn.position, Quaternion.identity);
                    balaClon.GetComponent<Rigidbody>().AddForce(transform.forward * 10, ForceMode.Impulse);
                    if (NumBalas == 0)
                    {
                        Destroy(gameObject);
                    }
                }
            }
        }
        else
        {
            detectadoEnemigo = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 2.5f);
        //Gizmos.DrawRay(transform.position, 5 * (enemigo.position - transform.position)); //NO HAY ERROR
    }
}
