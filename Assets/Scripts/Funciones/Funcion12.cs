using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion12 : MonoBehaviour
{
    
    Vector3 GenerarVector()
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);

        return new Vector3(x, y, z);
    }

    
    void Start()
    {
        Vector3 vectorAleatorio = GenerarVector();
        Debug.Log("Vector Aleatorio: " + vectorAleatorio);
    }
}
