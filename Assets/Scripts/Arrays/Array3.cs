using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array3 : MonoBehaviour
{
    public string[] palabras; 

    void Start()
    {
        
        if (palabras != null && palabras.Length > 0)
        {
            string ultimoElemento = palabras[palabras.Length - 1]; 
            Debug.Log("El último elemento es: " + ultimoElemento);
        }
        else
        {
            Debug.Log("El array no contiene elementos.");
        }
    }
}
