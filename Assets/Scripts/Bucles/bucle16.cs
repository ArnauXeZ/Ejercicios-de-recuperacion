using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle16 : MonoBehaviour
{
    public float[] numeros;

    void Start()
    {
        MostrarPositivos();
    }

    void MostrarPositivos()
    {
        foreach (float num in numeros)
        {
            if (num > 0)
            {
                Debug.Log(num);
            }
        }
    }
}
