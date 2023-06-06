using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle14 : MonoBehaviour
{
    public int[] numeros;

    void Start()
    {
        int contador = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            int numero = numeros[i];
            if (numero % 2 != 0)
            {
                contador++;
            }
        }

        Debug.Log("Cantidad de números impares: " + contador);
    }
}
