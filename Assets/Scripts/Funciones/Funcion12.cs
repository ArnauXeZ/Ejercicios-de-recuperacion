using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion12 : MonoBehaviour
{
    public Vector3 GenerarVectorAleatorio()
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);
        return new Vector3(x, y, z);
    }
}
