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
                Debug.Log("La posici�n " + posicion + " est� fuera del l�mite izquierdo.");
            }
            else if (posicion.x > limiteDerecho)
            {
                Debug.Log("La posici�n " + posicion + " est� fuera del l�mite derecho.");
            }
            else if (posicion.y < limiteInferior)
            {
                Debug.Log("La posici�n " + posicion + " est� fuera del l�mite inferior.");
            }
            else if (posicion.y > limiteSuperior)
            {
                Debug.Log("La posici�n " + posicion + " est� fuera del l�mite superior.");
            }
            else
            {
                Debug.Log("La posici�n " + posicion + " est� dentro de los l�mites de pantalla.");
            }
        }
    }
}
