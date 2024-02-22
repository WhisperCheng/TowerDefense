using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text textVidas;
    public TMP_Text textDinero;
    public TMP_Text textTiempo;
    public TMP_Text textPuntuacionFinal;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textVidas.text = "Vidas = " + GameManager.Instance.vidasJugador;
        textPuntuacionFinal.text = "Puntuacion final: " + GameManager.Instance.puntuacion;
        if (GameManager.Instance.dinero <= 50)
        {
            textDinero.text = "Dinero = " + GameManager.Instance.dinero;
            textDinero.color = Color.red;
        }
        else if (GameManager.Instance.dinero >= 50)
        {
            textDinero.text = "Dinero = " + GameManager.Instance.dinero;
            textDinero.color = Color.white;
        }
        if (GameManager.Instance.tiempoManager <= 8)
        {
            textTiempo.text = "Tiempo = " + GameManager.Instance.tiempoManager.ToString("F2");
            textTiempo.color = Color.red;
        }
        else
        {
            textTiempo.text = "Tiempo = " + GameManager.Instance.tiempoManager.ToString("F2");
        }
    }
}
