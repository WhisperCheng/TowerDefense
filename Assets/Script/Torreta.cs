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
    float tiempoVida;
    // Start is called before the first frame update
    void Start()
    {
        detectadoEnemigo = false;
        NumBalas = 15;   
    }

    // Update is called once per frame
    void Update()
    {
        tiempoVida += Time.deltaTime;
        cooldown += Time.deltaTime;
        int mascara = 1 << 6;

        Collider[] detectado = Physics.OverlapSphere(transform.position, 3.5f, mascara);

        if(detectado.Length > 0)
        {
            enemigo = detectado[0].transform;
            transform.LookAt(enemigo.transform.position);
                        
            detectadoEnemigo = true;
            
            if (detectadoEnemigo == true)
            {
                if (cooldown > 0.5) 
                {
                    NumBalas--;
                    cooldown = 0;
                    balaClon = Instantiate(bala, spawn.position, Quaternion.identity);
                    balaClon.GetComponent<Rigidbody>().AddForce(transform.forward * 25, ForceMode.Impulse);
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
        if (tiempoVida == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 3.5f);
        //Gizmos.DrawRay(transform.position, 5 * (enemigo.position - transform.position)); //NO HAY ERROR
    }
}
