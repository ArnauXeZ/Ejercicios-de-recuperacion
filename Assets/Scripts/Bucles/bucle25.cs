using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle25 : MonoBehaviour
{
    public GameObject esferaPrefab;
    public int cantidadEsferas = 20;

    void Start()
    {
        for (int i = 0; i < cantidadEsferas; i++)
        {
            
            Vector3 posicionAleatoria = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));

            
            GameObject esfera = Instantiate(esferaPrefab, posicionAleatoria, Quaternion.identity);

            
            esfera.name = "Esfera" + (i + 1);
        }
    }
}
