using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion3 : MonoBehaviour
{
    void EsMenorOIgualACero(float numero)
    {
        if (numero <= 0f)
        {
            Debug.Log("El número es menor o igual a 0");
        }
        else
        {
            Debug.Log("El número es mayor que 0");
        }
    }
}
