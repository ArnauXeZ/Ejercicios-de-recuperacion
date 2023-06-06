using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle26 : MonoBehaviour
{
    public GameObject cuboPrefab;
    public int cantidadCubos = 20;

    private List<Vector3> posicionesOcupadas = new List<Vector3>();

    void Start()
    {
        for (int i = 0; i < cantidadCubos; i++)
        {
            
            Vector3 posicionAleatoria = GenerarPosicionAleatoriaNoRepetida();

            
            GameObject cubo = Instantiate(cuboPrefab, posicionAleatoria, Quaternion.identity);

            
            cubo.name = "Cubo" + (i + 1);
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
}
