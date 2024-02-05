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
    public float radio = 0.2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int mascara = 1 << 7;

        if (torretaActivado == true && Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.dinero >= 50)
        {
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit rayoTorreta;

            if (Physics.Raycast(laser, out rayoTorreta, mascara))
            {
                GameManager.Instance.RestaDineroTorreta();
                GameObject.Instantiate(torreta, rayoTorreta.point, Quaternion.identity);
            }
        }
        if (vallaActivado == true && Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.dinero >= 20)
        {
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit[] golpes;
            

            golpes = Physics.SphereCastAll(transform.position, radio, laser.direction,Mathf.Infinity,mascara);
            Debug.Log(golpes.Length);
            if (golpes.Length == 1)
            {
                GameManager.Instance.RestaDineroValla();
                GameObject.Instantiate(valla, golpes[0].point, Quaternion.identity);
            }
        }
    }
}
