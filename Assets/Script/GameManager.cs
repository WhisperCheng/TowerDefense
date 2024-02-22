using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int vidasJugador;
    public int PuntosEnemigosEliminados;
    public int dinero;
    public int puntuacion;
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
            dinero = 100;
            tiempoManager = 65;
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
    }
    public void AumentarDineroEnemigo()
    {
        dinero += 50;
        PuntosEnemigosEliminados += 20;
    }
    public void AumentarDineroEnemigoMetal()
    {
        dinero += 100;
        PuntosEnemigosEliminados += 50;
    }
    public void AumentarDineroEnemigoMadera()
    {
        dinero += 20;
        PuntosEnemigosEliminados += 10;
    }
    public void RestaDineroTorreta()
    {
        dinero -= 50;
    }
    public void RestaDineroValla()
    {
        dinero -= 20;
    }
    public void ResultadoPuntuacion()
    {
        puntuacion = PuntosEnemigosEliminados * 2 + dinero;
    }
    public void ResultadoPuntuacionPerder()
    {
        puntuacion = PuntosEnemigosEliminados + dinero;
    }
}
