using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bala : MonoBehaviour
{
    float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        int mascara = 1 << 6;

        Collider[] detectado = Physics.OverlapSphere(transform.position, 2.5f, mascara);

        transform.LookAt(detectado[0].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo > 3)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo" || collision.gameObject.tag == "EnemigoMetal" || collision.gameObject.tag == "EnemigoMadera")
        {
            collision.gameObject.GetComponent<Enemigo>().QuitarVida();
            Destroy(gameObject);
        }
    }
}
