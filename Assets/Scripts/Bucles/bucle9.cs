using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle9 : MonoBehaviour
{
    public string[] palabras;

    void Start()
    {
        for (int i = 0; i < palabras.Length; i++)
        {
            string palabra = palabras[i];
            char primeraLetra = char.ToLower(palabra[0]);

            if (primeraLetra != 'a' && primeraLetra != 'e' && primeraLetra != 'i' && primeraLetra != 'o' && primeraLetra != 'u')
            {
                Debug.Log("String: " + palabra);
                Debug.Log("Posición: " + i);
                break;
            }
        }
    }
}
