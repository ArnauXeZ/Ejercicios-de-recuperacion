using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion14 : MonoBehaviour
{
    [SerializeField] private float velocidad = 1f;

    void Desplazar()
    {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Desplazar();
        }

    }
}