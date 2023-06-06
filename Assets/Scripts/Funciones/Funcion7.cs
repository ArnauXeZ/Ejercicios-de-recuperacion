using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Funcion7 : MonoBehaviour
{
    [SerializeField] private string mesPrueba = "july"; 

    
    int ObtenerDiasDelMes(string mes)
    {
        switch (mes)
        {
            case "january":
            case "march":
            case "may":
            case "july":
            case "august":
            case "october":
            case "december":
                return 31;

            case "april":
            case "june":
            case "september":
            case "november":
                return 30;

            case "february":
                return 28;

            default:
                return -1; 
        }
    }

    
    void Start()
    {
        int numDias = ObtenerDiasDelMes(mesPrueba);

        if (numDias > 0)
        {
            Debug.Log("El mes de " + mesPrueba + " tiene " + numDias + " días.");
        }
        else
        {
            Debug.Log("El mes " + mesPrueba + " no es válido.");
        }
    }

}
