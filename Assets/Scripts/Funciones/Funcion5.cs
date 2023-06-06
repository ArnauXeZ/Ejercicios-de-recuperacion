using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Funcion5 : MonoBehaviour
{
    [SerializeField] private int anioPrueba = 2024; 

    
    bool EsAnioBisiesto(int anio)
    {
        if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
        {
            return true; 
        }
        else
        {
            return false; 
        }
    }

    
    void Start()
    {
        bool esBisiesto = EsAnioBisiesto(anioPrueba);

        if (esBisiesto)
        {
            Debug.Log(anioPrueba + " es un año bisiesto.");
        }
        else
        {
            Debug.Log(anioPrueba + " no es un año bisiesto.");
        }
    }
}
