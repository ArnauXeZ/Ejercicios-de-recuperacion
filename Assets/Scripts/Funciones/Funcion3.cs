using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion3 : MonoBehaviour
{
    void EsMenorOIgualACero(float numero)
    {
        if (numero <= 0f)
        {
            Debug.Log("El n�mero es menor o igual a 0");
        }
        else
        {
            Debug.Log("El n�mero es mayor que 0");
        }
    }
}
