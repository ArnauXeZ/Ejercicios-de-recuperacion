using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle15 : MonoBehaviour
{
    public int[] numeros;

    void Start()
    {
        int contadorPares = 0;
        int contadorImpares = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            int numero = numeros[i];
            if (numero % 2 == 0)
            {
                contadorPares++;
            }
            else
            {
                contadorImpares++;
            }
        }

        Debug.Log("Cantidad de números pares: " + contadorPares);
        Debug.Log("Cantidad de números impares: " + contadorImpares);
    }
}
