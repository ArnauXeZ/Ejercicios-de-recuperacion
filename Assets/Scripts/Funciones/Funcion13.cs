using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion13 : MonoBehaviour
{
    public Vector3 GenerarVectorAleatorio(float minValor, float maxValor)
    {
        float x = Random.Range(minValor, maxValor);
        float y = Random.Range(minValor, maxValor);
        float z = Random.Range(minValor, maxValor);
        return new Vector3(x, y, z);
    }
}
