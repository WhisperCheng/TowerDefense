using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public Camara camara;
    // Start is called before the first frame update
    public void BotonTorreta()
    {
        Debug.Log("Torreta Activada, Valla Desactivada");
        camara.torretaActivado = true;
        camara.vallaActivado = false;
    }
    public void BotonValla() 
    {
        Debug.Log("Torreta Desactivada, Valla Activada");
        camara.vallaActivado = true;
        camara.torretaActivado = false;
    }
    public void Cancelar()
    {
        Debug.Log("Ambos objetos desactivados");
        camara.vallaActivado = false;
        camara.torretaActivado = false;
    }
}
