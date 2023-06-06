using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle24 : MonoBehaviour
{
    public float[] numeros;

    void Start()
    {
        int sumaPares = 0;
        int sumaImpares = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumaPares += (int)numeros[i];
            }
            else
            {
                sumaImpares += (int)numeros[i];
            }
        }

        Debug.Log("La suma de los elementos en posiciones pares del array es: " + sumaPares);
        Debug.Log("La suma de los elementos en posiciones impares del array es: " + sumaImpares);
    }
}