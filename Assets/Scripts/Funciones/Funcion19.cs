using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Funcion19 : MonoBehaviour
{
    public class Escala : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Escalar();
            }
        }

        void Escalar()
        {
            transform.localScale += new Vector3(1, 1, 1);
        }
    }
}
