using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle12 : MonoBehaviour
{
    public int[] numeros;

    void Start()
    {
        int contadorPares = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            int numero = numeros[i];
            if (numero % 2 == 0)
            {
                contadorPares++;
            }
        }

        Debug.Log("Cantidad de números pares: " + contadorPares);
    }
}
