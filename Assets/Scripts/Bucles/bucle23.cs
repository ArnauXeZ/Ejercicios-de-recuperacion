using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle23 : MonoBehaviour
{
    public float[] numeros;

    void Start()
    {
        float suma = CalcularSumaPosicionesImpares(numeros);
        Debug.Log("La suma de los elementos en posiciones impares del array es: " + suma);
    }

    float CalcularSumaPosicionesImpares(float[] array)
    {
        float suma = 0;

        for (int i = 1; i < array.Length; i += 2)
        {
            suma += array[i];
        }

        return suma;
    }
}
