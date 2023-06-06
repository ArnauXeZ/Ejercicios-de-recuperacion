using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array6 : MonoBehaviour
{
    public string[] palabras; 

    void Start()
    {
        
        if (palabras != null && palabras.Length > 0)
        {
            
            int indiceAleatorio = Random.Range(0, palabras.Length);

            
            string elementoAleatorio = palabras[indiceAleatorio];

            
            Debug.Log("Elemento aleatorio: " + elementoAleatorio);
        }
        else
        {
            Debug.Log("El array no contiene elementos.");
        }
    }
}
