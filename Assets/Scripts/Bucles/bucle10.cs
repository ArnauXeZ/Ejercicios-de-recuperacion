using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle10 : MonoBehaviour
{
    public string[] palabras;

    void Start()
    {
        for (int i = 0; i < palabras.Length; i++)
        {
            string palabra = palabras[i];
            Debug.Log("Valor: " + palabra);
            Debug.Log("Posición: " + i);
        }

    }
}