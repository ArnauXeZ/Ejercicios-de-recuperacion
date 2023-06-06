using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle17 : MonoBehaviour
{
    public float[] numeros;

    void Start()
    {
        ContarElementos();
    }

    void ContarElementos()
    {
        int positivos = 0;
        int negativos = 0;
        int ceros = 0;

        foreach (float num in numeros)
        {
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }
            else
            {
                ceros++;
            }
        }

        Debug.Log("Cantidad de elementos positivos: " + positivos);
        Debug.Log("Cantidad de elementos negativos: " + negativos);
        Debug.Log("Cantidad de elementos que valen 0: " + ceros);
    }
}
