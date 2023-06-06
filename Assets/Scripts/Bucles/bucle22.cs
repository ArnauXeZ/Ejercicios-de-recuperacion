using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle22 : MonoBehaviour
{
    public float[] numeros;

    void Start()
    {
        float suma = CalcularSumaPosicionesPares(numeros);
        Debug.Log("La suma de los elementos en posiciones pares del array es: " + suma);
    }

    float CalcularSumaPosicionesPares(float[] array)
    {
        float suma = 0;

        for (int i = 0; i < array.Length; i += 2)
        {
            suma += array[i];
        }

        return suma;
    }
}
