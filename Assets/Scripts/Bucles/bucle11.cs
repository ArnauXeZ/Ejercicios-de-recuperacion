using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle11 : MonoBehaviour
{
    public int[] numeros;

    void Start()
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            int numero = numeros[i];
            if (numero % 2 == 0)
            {
                Debug.Log("Número par: " + numero);
            }
        }
    }
}
