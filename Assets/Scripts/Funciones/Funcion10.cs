using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion10 : MonoBehaviour
{
    [SerializeField] private string palabraPrueba = "Hola"; 

    
    void ComprobarInicioConVocal(string palabra)
    {
        char primerCaracter = char.ToLower(palabra[0]); 

        if (primerCaracter == 'a' || primerCaracter == 'e' || primerCaracter == 'i' || primerCaracter == 'o' || primerCaracter == 'u')
        {
            Debug.Log("La palabra empieza por " + primerCaracter);
        }
        else
        {
            Debug.Log("La palabra no empieza por vocal");
        }
    }

    
    void Start()
    {
        ComprobarInicioConVocal(palabraPrueba);
    }
}
