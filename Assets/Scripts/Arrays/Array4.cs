using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array4 : MonoBehaviour
{
    public string[] palabras; 

    void Start()
    {
        
        if (palabras != null && palabras.Length > 0)
        {
            
            for (int i = 0; i < palabras.Length; i++)
            {
                if (i % 2 == 0) 
                {
                    string elemento = palabras[i]; 
                    Debug.Log("Elemento en posición par [" + i + "]: " + elemento);
                }
            }
        }
        else
        {
            Debug.Log("El array no contiene elementos.");
        }
    }
}
