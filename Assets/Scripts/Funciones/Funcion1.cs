using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion1 : MonoBehaviour
{

    public int numeroPrueba = 7; 

    
    bool EsPar(int numero)
    {
        if (numero % 2 == 0)
        {
            return true; // El n�mero es par
        }
        else
        {
            return false; // El n�mero es impar
        }
    }

    
    void Start()
    {
        bool esPar = EsPar(numeroPrueba);

        if (esPar)
        {
            Debug.Log(numeroPrueba + " es un n�mero par.");
        }
        else
        {
            Debug.Log(numeroPrueba + " es un n�mero impar.");
        }
    }
}
