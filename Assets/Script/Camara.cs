using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Camara : MonoBehaviour
{
    public GameObject torreta;
    public GameObject valla;
    public bool torretaActivado;
    public bool vallaActivado;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (torretaActivado == true && Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.dinero >= 50)
        {
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit rayoTorreta;

            if (Physics.Raycast(laser, out rayoTorreta))
            {
                GameManager.Instance.RestaDineroTorreta();
                GameObject.Instantiate(torreta, rayoTorreta.point, Quaternion.identity);
            }
        }
        if (vallaActivado == true && Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.dinero >= 20)
        {
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit rayoValla;

            if (Physics.Raycast(laser,out rayoValla))
            {
                GameManager.Instance.RestaDineroValla();
                GameObject.Instantiate(valla, rayoValla.point, Quaternion.identity);
            }
        }
    }
}
