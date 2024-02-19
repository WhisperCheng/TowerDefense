using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenasManager : MonoBehaviour
{
    public bool ActivarNivel;
    public bool ActivarInstrucciones;
    public bool ActivarAtras;
    public bool ActivarJuegoFacil;
    public bool ActivarJuegoNormal;
    public bool ActivarJuegoDificil;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ActivarNivel == true)
        {
            SceneManager.LoadScene("Nivel");
        }
        if (ActivarAtras == true)
        {
            SceneManager.LoadScene("Menu Principal");
        }
        if (ActivarInstrucciones == true)
        {
            SceneManager.LoadScene("Instrucciones");
        }
        if (GameManager.Instance.vidasJugador == 0) 
        {
            GameManager.Instance.ResultadoPuntuacionPerder();
            SceneManager.LoadScene("Muerte");
        }
        if (GameManager.Instance.tiempoManager <= 0)
        {
            GameManager.Instance.ResultadoPuntuacion();
            SceneManager.LoadScene("Final");
        }
        if (ActivarJuegoFacil == true)
        {
            SceneManager.LoadScene("JuegoFacil");
        }
        if (ActivarJuegoNormal == true)
        {
            SceneManager.LoadScene("JuegoNormal");
        }
        if (ActivarJuegoDificil == true)
        {
            SceneManager.LoadScene("JuegoDificil");
        }
    }
}
