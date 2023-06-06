using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion13 : MonoBehaviour
{
    [SerializeField] private float minValor = -10f; 
    [SerializeField] private float maxValor = 10f; 

   
    Vector3 GenerarVector(float min, float max)
    {
        float x = Random.Range(min, max);
        float y = Random.Range(min, max);
        float z = Random.Range(min, max);

        return new Vector3(x, y, z);
    }

   
    void Start()
    {
        Vector3 vectorAleatorio = GenerarVector(minValor, maxValor);
        Debug.Log("Vector Aleatorio: " + vectorAleatorio);
    }
}
