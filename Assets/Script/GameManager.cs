using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int vidasJugador;
    public int dinero;
    public float tiempoManager;
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
            dinero = 5000;
            tiempoManager = 60;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    private void Update()
    {
        tiempoManager -= Time.deltaTime;
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
    public void AumentarDinero()
    {
        dinero += 50;
    }
    public void RestaDineroTorreta()
    {
        dinero -= 50;
    }
    public void RestaDineroValla()
    {
        dinero -= 20;
    }

}
