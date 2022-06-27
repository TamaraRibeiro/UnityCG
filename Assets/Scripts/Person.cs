using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{

    float unidadesTx, unidadesTz; //translação em x e z
    float unidadesT, unidadesR; //unidades tranlação e rotação 
    float vT, vR; //velocidade de translação e rotação 

    float vT1;

    void Start()
    {
        vT1 = 5.0f;
        vT = 2.5f; 
        vR = 30.0f;
    }

    void Update()
    {
        //A ou seta esq = -1 | D ou seta dir = 1
        unidadesTx = Input.GetAxis("Horizontal") * vT1 * Time.deltaTime;
        
        //S ou seta baixo = -1 | W ou seta cima = 1
        unidadesTz = Input.GetAxis("Vertical") * vT1 * Time.deltaTime;

        transform.Translate(unidadesTx, 0, unidadesTz);

        unidadesT = Input.GetAxis("Vertical") * vT * Time.deltaTime;
        transform.Translate(0,0,-unidadesT);

        unidadesR = Input.GetAxis("Horizontal") * vR * Time.deltaTime;
        transform.Rotate(0,unidadesR,0);
    }
}
