using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array8 : MonoBehaviour
{
    public GameObject[] elementos; 

    void Start()
    {
        
        if (elementos != null && elementos.Length > 0)
        {
            
            int indiceAleatorio = Random.Range(0, elementos.Length);

            
            Instantiate(elementos[indiceAleatorio], Vector3.zero, Quaternion.identity);
        }
        else
        {
            Debug.Log("El array no contiene elementos.");
        }
    }
}
