using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion18 : MonoBehaviour
{
    [SerializeField] private float velocidad = 1f; 

    
    void Desplazar(Vector3 direccion)
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Desplazar(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Desplazar(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Desplazar(Vector3.up);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Desplazar(Vector3.down);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            Desplazar(Vector3.back);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Desplazar(Vector3.forward);
        }
    }
}

