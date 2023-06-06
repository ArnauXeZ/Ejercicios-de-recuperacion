using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array9 : MonoBehaviour
{
    public int[] elementos; 

    void Start()
    {
        if (elementos.Length > 10)
        {
            Debug.Log("El array tiene más de 10 elementos");
        }
        else
        {
            Debug.Log("El array tiene " + elementos.Length + " elementos");
        }
    }
}
