using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array2 : MonoBehaviour
{
    public float[] numeros; 

    void Start()
    {
        
        if (numeros != null && numeros.Length > 0)
        {
            float primerElemento = numeros[0]; 
            Debug.Log("El primer elemento es: " + primerElemento);
        }
        else
        {
            Debug.Log("El array no contiene elementos.");
        }
    }
}
