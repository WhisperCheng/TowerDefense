using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int vidas;
    int dinero;
    float tiempo = 60;
    public static GameManager Instance { get; private set;}

    private void Awake()
    {
        
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            vidas = 3;
            dinero = 50;
        }
    }
    private void Update()
    {
        tiempo -= Time.deltaTime;
    }

}
