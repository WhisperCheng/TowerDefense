using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valla : MonoBehaviour
{
    public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        tiempo = 0;
    }

    // Update is called once per frame

    // Le falta al codigo hacer que cuando se crea que modifique el espacio de movimiento de la IA
    void Update()
    {
        tiempo += Time.deltaTime;
        Debug.Log(tiempo);
        
        if (tiempo > 10)
        {
            Destroy(gameObject);
        }
    }
}
