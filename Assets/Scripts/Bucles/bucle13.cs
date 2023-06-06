using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle13 : MonoBehaviour
{
    public int[] numeros;

    void Start()
    {
        Debug.Log("Números impares:");

        for (int i = 0; i < numeros.Length; i++)
        {
            int numero = numeros[i];
            if (numero % 2 != 0)
            {
                Debug.Log(numero);
            }
        }
    }
}
