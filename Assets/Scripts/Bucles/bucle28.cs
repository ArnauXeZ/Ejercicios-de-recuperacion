using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle28 : MonoBehaviour
{
    public GameObject capsulaPrefab;
    public int cantidadCapsulas = 20;

    private List<Vector3> posicionesOcupadas = new List<Vector3>();

    void Start()
    {
        for (int i = 0; i < cantidadCapsulas; i++)
        {
            
            Vector3 posicionAleatoria = GenerarPosicionAleatoriaNoRepetida();

            
            Vector3 escalaAleatoria = GenerarEscalaAleatoriaNoNegativa();

            
            Color colorAleatorio = GenerarColorAleatorio();

            
            GameObject capsula = Instantiate(capsulaPrefab, posicionAleatoria, Quaternion.identity);
            capsula.transform.localScale = escalaAleatoria;

            
            Renderer renderer = capsula.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = colorAleatorio;
            }

            
            capsula.name = "Capsula" + (i + 1);
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

    private Color GenerarColorAleatorio()
    {
        
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        
        return new Color(r, g, b);
    }
}
