using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public Camara camara;
    public EscenasManager escenas;
    // Start is called before the first frame update
    public void BotonTorreta()
    {
        //Debug.Log("Torreta Activada, Valla Desactivada");
        camara.torretaActivado = true;
        camara.vallaActivado = false;
    }
    public void BotonValla() 
    {
        //Debug.Log("Torreta Desactivada, Valla Activada");
        camara.vallaActivado = true;
        camara.torretaActivado = false;
    }
    public void Cancelar()
    {
        //Debug.Log("Ambos objetos desactivados");
        camara.vallaActivado = false;
        camara.torretaActivado = false;
    }
    public void BotonNivel()
    {
        escenas.ActivarNivel = true;
    }
    public void BotonInstrucciones()
    {
        escenas.ActivarInstrucciones = true;
    }
    public void BotonVolver()
    {
        escenas.ActivarAtras = true;
    }
    public void BotonJuegoFacil()
    {
        escenas.ActivarJuegoFacil = true;
    }
    public void BotonJuegoNormal()
    {
        escenas.ActivarJuegoNormal = true;
    }
    public void BotonJuegoDificil()
    {
        escenas.ActivarJuegoDificil = true;
    }
}
