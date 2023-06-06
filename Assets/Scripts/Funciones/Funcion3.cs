using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion3 : MonoBehaviour
{
    [SerializeField] private float numeroPrueba = -2.5f; 

    
    void VerificarMenorIgualCero(float numero)
    {
        if (numero <= 0)
        {
            Debug.Log("El número es menor o igual a 0");
        }
        else
        {
            Debug.Log("El número es mayor que 0");
        }
    }

    
    void Start()
    {
        VerificarMenorIgualCero(numeroPrueba);
    }
}
