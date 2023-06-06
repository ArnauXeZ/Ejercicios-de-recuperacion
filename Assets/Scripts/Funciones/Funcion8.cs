using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Funcion8 : MonoBehaviour
{
    [SerializeField] private string mesPrueba = "july"; 

    
    string ObtenerEstacionDelAnio(string mes)
    {
        switch (mes)
        {
            case "december":
            case "january":
            case "february":
                return "invierno";

            case "march":
            case "april":
            case "may":
                return "primavera";

            case "june":
            case "july":
            case "august":
                return "verano";

            case "september":
            case "october":
            case "november":
                return "otoño";

            default:
                return "invalid"; 
        }
    }

    
    void Start()
    {
        string estacion = ObtenerEstacionDelAnio(mesPrueba);

        if (estacion != "invalid")
        {
            Debug.Log("El mes de " + mesPrueba + " corresponde a la estación de " + estacion + ".");
        }
        else
        {
            Debug.Log("El mes " + mesPrueba + " no es válido.");
        }
    }
}
