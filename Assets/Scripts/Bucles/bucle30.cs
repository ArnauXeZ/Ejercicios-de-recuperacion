using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle30 : MonoBehaviour
{
    public Vector3[] posiciones;
    public float limiteIzquierdo;
    public float limiteDerecho;
    public float limiteInferior;
    public float limiteSuperior;

    void Start()
    {
        for (int i = 0; i < posiciones.Length; i++)
        {
            Vector3 posicion = posiciones[i];

            if (posicion.x < limiteIzquierdo)
            {
                Debug.Log("La posición " + posicion + " está fuera del límite izquierdo.");
            }
            else if (posicion.x > limiteDerecho)
            {
                Debug.Log("La posición " + posicion + " está fuera del límite derecho.");
            }
            else if (posicion.y < limiteInferior)
            {
                Debug.Log("La posición " + posicion + " está fuera del límite inferior.");
            }
            else if (posicion.y > limiteSuperior)
            {
                Debug.Log("La posición " + posicion + " está fuera del límite superior.");
            }
            else
            {
                Debug.Log("La posición " + posicion + " está dentro de los límites de pantalla.");
            }
        }
    }
}
