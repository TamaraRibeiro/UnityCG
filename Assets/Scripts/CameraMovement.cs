using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    float unidadesRx, unidadesRy; //unidades de rotação em x e y 
    float vR; //velocidade de rotação 

    public GameObject person;

    void Start()
    {
        vR = 50f;
        unidadesRx = 0f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        unidadesRx += Input.GetAxis("Mouse Y") * vR * Time.deltaTime;
        unidadesRx = Mathf.Clamp(unidadesRx, -60f, 60f); 
        transform.localEulerAngles = new Vector3(-unidadesRx, 0, 0);
    
        unidadesRy = Input.GetAxis("Mouse X") * vR * Time.deltaTime;
        person.transform.Rotate(0, unidadesRy, 0); 
    }
}
