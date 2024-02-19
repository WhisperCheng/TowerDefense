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
        textDinero.text = "Dinero = " + GameManager.Instance.dinero;
        textTiempo.text = "Tiempo = " + GameManager.Instance.tiempoManager.ToString("F2");
        textPuntuacionFinal.text = "Puntuacion final = " + GameManager.Instance.puntuacion;
    }
}
