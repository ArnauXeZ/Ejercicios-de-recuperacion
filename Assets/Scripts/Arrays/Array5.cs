using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array5 : MonoBehaviour
{
    public Vector3[] vectores; 

    void Start()
    {
       
        if (vectores != null && vectores.Length > 0)
        {
           
            for (int i = 0; i < vectores.Length; i++)
            {
                if (i % 2 != 0) 
                {
                    Vector3 elemento = vectores[i]; 
                    Debug.Log("Elemento en posición impar [" + i + "]: " + elemento);
                }
            }
        }
        else
        {
            Debug.Log("El array no contiene elementos.");
        }
    }
}
