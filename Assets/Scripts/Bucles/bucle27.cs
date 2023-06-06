using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle27 : MonoBehaviour
{
    public GameObject esferaPrefab;
    public int cantidadEsferas = 20;

    private List<Vector3> posicionesOcupadas = new List<Vector3>();

    void Start()
    {
        for (int i = 0; i < cantidadEsferas; i++)
        {
            
            Vector3 posicionAleatoria = GenerarPosicionAleatoriaNoRepetida();

            
            Vector3 escalaAleatoria = GenerarEscalaAleatoriaNoNegativa();

            
            GameObject esfera = Instantiate(esferaPrefab, posicionAleatoria, Quaternion.identity);
            esfera.transform.localScale = escalaAleatoria;

            
            esfera.name = "Esfera" + (i + 1);
        }
    }

    private Vector3 GenerarPosicionAleatoriaNoRepetida()
    {
        Vector3 posicionAleatoria;
        do
        {
            
            posicionAleatoria = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
        } while (posicionesOcupadas.Contains(posicionAleatoria));

        
        posicionesOcupadas.Add(posicionAleatoria);

        return posicionAleatoria;
    }

    private Vector3 GenerarEscalaAleatoriaNoNegativa()
    {
        Vector3 escalaAleatoria;
        do
        {
            
            escalaAleatoria = new Vector3(Random.Range(0.1f, 5f), Random.Range(0.1f, 5f), Random.Range(0.1f, 5f));
        } while (escalaAleatoria.x <= 0f || escalaAleatoria.y <= 0f || escalaAleatoria.z <= 0f);

        return escalaAleatoria;
    }
}
