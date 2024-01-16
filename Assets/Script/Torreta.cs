using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Torreta : MonoBehaviour
{
    int NumBalas;
    // Start is called before the first frame update
    void Start()
    {
        NumBalas = 10;   
    }

    // Update is called once per frame
    void Update()
    {
        int mascara = 1 << 6;

        Collider[] detectado = Physics.OverlapSphere(transform.position, 2.5f, mascara);

        if(detectado.Length > 0)
        {
            transform.LookAt(detectado[0].transform.position);
            
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 2.5f);
    }
}
