using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion15 : MonoBehaviour
{
    [SerializeField] private float velocidad = 1f; 

   
    void Desplazar()
    {
        transform.Translate(Vector3.right * velocidad * Time.deltaTime);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Desplazar();
        }
    }
}
