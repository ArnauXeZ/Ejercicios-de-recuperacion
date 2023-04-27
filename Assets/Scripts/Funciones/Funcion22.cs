using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion22 : MonoBehaviour
{
    Color colorAleatorio;

    void Start()
    {
        colorAleatorio = new Color(Random.value, Random.value, Random.value, 1.0f);
    }

    Color ObtenerColorAleatorio()
    {
        return colorAleatorio;
    }
}
