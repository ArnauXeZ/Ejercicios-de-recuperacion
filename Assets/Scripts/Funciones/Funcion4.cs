using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion4 : MonoBehaviour
{
    [SerializeField] private int numeroPrueba = 0; 

    
    bool EsIgualACero(int numero)
    {
        return numero == 0;
    }

    
    void Start()
    {
        bool esIgualACero = EsIgualACero(numeroPrueba);

        if (esIgualACero)
        {
            Debug.Log("El número es igual a cero.");
        }
        else
        {
            Debug.Log("El número no es igual a cero.");
        }
    }
}
