using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion10 : MonoBehaviour
{
    public void ComprobarPalabra(string palabra)
    {
        char primeraLetra = char.ToLower(palabra[0]);
        if (primeraLetra == 'a' || primeraLetra == 'e' || primeraLetra == 'i' || primeraLetra == 'o' || primeraLetra == 'u')
        {
            Debug.Log("La palabra empieza por " + primeraLetra);
        }
        else
        {
            Debug.Log("La palabra no empieza por vocal");
        }
    }
}
