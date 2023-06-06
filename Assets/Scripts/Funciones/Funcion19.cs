using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Funcion19 : MonoBehaviour
{
    
    void Aumentar()
    {
        transform.localScale += new Vector3(1f, 1f, 1f);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Aumentar();
        }
    }
}
