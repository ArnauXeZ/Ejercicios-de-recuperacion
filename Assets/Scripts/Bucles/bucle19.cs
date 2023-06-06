using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle19 : MonoBehaviour
{
    void Start()
    {
        GenerarNumerosAleatorios();
    }

    void GenerarNumerosAleatorios()
    {
        System.Random rand = new System.Random();
        int anio = 0;

        while (!EsBisiesto(anio))
        {
            anio = rand.Next(1, 2024);
            Debug.Log("A�o aleatorio: " + anio);
        }

        Debug.Log("Se gener� un a�o bisiesto. fin.");
    }

    bool EsBisiesto(int anio)
    {
        return (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
    }
}
