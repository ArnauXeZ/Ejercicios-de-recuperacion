using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion2 : MonoBehaviour
{
    [SerializeField] private float numeroPrueba = 3.5f; 

    
    bool EsMayorQueCero(float numero)
    {
        if (numero > 0)
        {
            return true;
        }
        else
        {
            return false; 
        }
    }

    
    void Start()
    {
        bool esMayorQueCero = EsMayorQueCero(numeroPrueba);

        if (esMayorQueCero)
        {
            Debug.Log(numeroPrueba + " es mayor que cero.");
        }
        else
        {
            Debug.Log(numeroPrueba + " no es mayor que cero.");
        }
    }
}
