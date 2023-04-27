using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion9 : MonoBehaviour
{
    void EmpiezaPorA(string palabra)
    {
        if (palabra.ToLower().StartsWith("a"))
        {
            Debug.Log("La palabra empieza por " + palabra[0]);
        }
        else
        {
            Debug.Log("La palabra no empieza por la letra a / A");
        }
    }
}
