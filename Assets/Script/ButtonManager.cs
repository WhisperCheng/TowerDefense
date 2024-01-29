using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public bool torretaActivado;
    public bool vallaActivado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BotonTorreta()
    {
        Debug.Log("Torreta Activada, Valla Desactivada");
        torretaActivado = true;
        vallaActivado = false;
    }
    public void BotonValla() 
    {
        Debug.Log("Torreta Desactivada, Valla Activada");
        vallaActivado = true;
        torretaActivado = false;
    }
    public void Cancelar()
    {
        Debug.Log("Ambos objetos desactivados");
        vallaActivado = false;
        torretaActivado = false;
    }
}
