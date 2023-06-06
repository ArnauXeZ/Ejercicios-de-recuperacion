using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle21 : MonoBehaviour
{
    public int[] numeros;

    void Start()
    {
        int producto = CalcularProducto(numeros);
        Debug.Log("El producto de los elementos del array es: " + producto);
    }

    int CalcularProducto(int[] array)
    {
        int producto = 1;

        for (int i = 0; i < array.Length; i++)
        {
            producto *= array[i];
        }

        return producto;
    }
}
