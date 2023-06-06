using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion9 : MonoBehaviour
{
    [SerializeField] private string palabraPrueba = "Hola"; 

    
    void ComprobarInicioConA(string palabra)
    {
        char primerCaracter = char.ToLower(palabra[0]); 

        if (primerCaracter == 'a')
        {
            Debug.Log("La palabra empieza por " + primerCaracter);
        }
        else
        {
            Debug.Log("La palabra no empieza por la letra a / A");
        }
    }

    
    void Start()
    {
        ComprobarInicioConA(palabraPrueba);
    }
}
