using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    int vidas;
    public Transform Objetivo;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        vidas = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //agent.destination = Objetivo.transform.position;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Copa")
        {
            Debug.Log(collision.gameObject.tag);

            GameManager.Instance.QuitarVidaJugador();
            Destroy(gameObject);
        }
    }

    public void QuitarVida()
    {
        vidas--;
        if (vidas == 0)
        {
            GameManager.Instance.AumentarDinero();
            Destroy(gameObject);
        }
    }
}
