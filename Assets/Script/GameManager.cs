using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int vidasJugador;
    int dinero;
    float tiempo;
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
            vidasJugador = 3;
            dinero = 50;
            tiempo = 60;
        }
    }
    private void Update()
    {
        tiempo -= Time.deltaTime;
    }
    public void QuitarVidaJugador()
    {
        vidasJugador--;
        Debug.Log(vidasJugador);
        if (vidasJugador == 0)
        {
            Time.timeScale = 0;
        }
    }

}
