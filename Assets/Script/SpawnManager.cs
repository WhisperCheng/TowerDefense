using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float cooldown;
    public GameObject[] listaEnemigos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldown += Time.deltaTime;
        if (GameManager.Instance.tiempoManager <= 60 && cooldown >= 3)
        {
            Vector3 position = new Vector3(Random.Range(-5.72f, 12.43f), 0, Random.Range(6.63f, 9));
            Instantiate(listaEnemigos[Random.Range(0,3)], position, Quaternion.identity);
            cooldown = 0;
        }
        if (GameManager.Instance.tiempoManager <= 45 && cooldown >= 2) 
        {
            Vector3 position = new Vector3(Random.Range(-5.72f, 12.43f), 0, Random.Range(6.63f, 9));
            Instantiate(listaEnemigos[Random.Range(0, 3)], position, Quaternion.identity);
            cooldown = 0;
        }
        if (GameManager.Instance.tiempoManager <= 30 && cooldown >= 1)
        {
            Vector3 position = new Vector3(Random.Range(-5.72f, 12.43f), 0, Random.Range(6.63f, 9));
            Instantiate(listaEnemigos[Random.Range(0, 3)], position, Quaternion.identity);
            cooldown = 0;
        }
        if (GameManager.Instance.tiempoManager <= 8 && cooldown >= 0.5)
        {
            Vector3 position = new Vector3(Random.Range(-5.72f, 12.43f), 0, Random.Range(6.63f, 9));
            Instantiate(listaEnemigos[Random.Range(0, 3)], position, Quaternion.identity);
            cooldown = 0;
        }
    }
    /* x = -5.72 && z = 6.63
    z = 9 && x = 12.43  && y = 0 */
}
