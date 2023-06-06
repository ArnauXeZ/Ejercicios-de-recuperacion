using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array7 : MonoBehaviour
{
    public Color[] colores; 

    void Start()
    {
        
        if (colores != null)
        {
            int cantidadElementos = colores.Length;
            Debug.Log("Cantidad de elementos: " + cantidadElementos);
        }
        else
        {
            Debug.Log("El array no contiene elementos.");
        }
    }
}
