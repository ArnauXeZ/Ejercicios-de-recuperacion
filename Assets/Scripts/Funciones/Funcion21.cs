using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion21 : MonoBehaviour
{
    
    public Material objetoMaterial;

    
    Color GenerarColorAleatorio()
    {
        float r = Random.Range(0f, 1f); 
        float g = Random.Range(0f, 1f); 
        float b = Random.Range(0f, 1f); 

        return new Color(r, g, b);
    }

    
    void Start()
    {
        Color colorAleatorio = GenerarColorAleatorio();
        CambiarColorObjeto(colorAleatorio);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Color colorAleatorio = GenerarColorAleatorio();
            CambiarColorObjeto(colorAleatorio);
        }
    }

    
    void CambiarColorObjeto(Color color)
    {
        objetoMaterial.color = color;
    }
}
