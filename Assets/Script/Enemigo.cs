using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    public int vidas;
    public Transform Objetivo;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (gameObject.tag == "EnemigoMetal")
        {
            vidas = 6;
        }
        else if (gameObject.tag == "EnemigoMadera")
        {
            vidas = 1;
        }
        else if (gameObject.tag == "Enemigo")
        {
            vidas = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = Objetivo.transform.position;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Copa")
        {
            //Debug.Log(collision.gameObject.tag);

            GameManager.Instance.QuitarVidaJugador();
            Destroy(gameObject);
        }
    }

    public void QuitarVida()
    {
        vidas--;
        if (gameObject.tag == "Enemigo" && vidas == 0)
        {
            GameManager.Instance.AumentarDineroEnemigo();
            Destroy(gameObject);
        }
        else if (gameObject.tag == "EnemigoMetal" && vidas == 0)
        {
            GameManager.Instance.AumentarDineroEnemigoMetal();
            Destroy(gameObject);
        }
        else if (gameObject.tag == "EnemigoMadera" && vidas == 0)
        {
            GameManager.Instance.AumentarDineroEnemigoMadera();
            Destroy(gameObject);
        }
    }
}
