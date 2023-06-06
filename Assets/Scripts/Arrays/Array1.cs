using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array1 : MonoBehaviour
{
    public int[] numeros; 

    void Start()
    {
        
        if (numeros != null && numeros.Length > 0)
        {
            int primerElemento = numeros[0]; 
            Debug.Log("El primer elemento es: " + primerElemento);
        }
        else
        {
            Debug.Log("El array no contiene elementos.");
        }
    }
}
