using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Camara : MonoBehaviour
{
    public GameObject torreta;
    public GameObject valla;
    public ButtonManager buttonManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonManager.torretaActivado == true && Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit rayoTorreta;

            if (Physics.Raycast(laser, out rayoTorreta))
            {
                GameObject.Instantiate(torreta, rayoTorreta.point, Quaternion.identity);
            }
        }
        if (buttonManager.vallaActivado == true && Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit rayoValla;

            if (Physics.Raycast(laser,out rayoValla))
            {
                GameObject.Instantiate(valla, rayoValla.point, Quaternion.identity);
            }
        }
    }
}
