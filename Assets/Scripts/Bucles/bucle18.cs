using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle18 : MonoBehaviour
{
    void Start()
    {
        GenerarNumerosAleatorios();
    }

    void GenerarNumerosAleatorios()
    {
        System.Random rand = new System.Random();
        int numero = 0;

        while (numero != 7)
        {
            numero = rand.Next(1, 11);
            Debug.Log("N�mero aleatorio: " + numero);
        }

        Debug.Log("Se gener� un 7. fin.");
    }
}
