using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle20 : MonoBehaviour
{
    void Start()
    {
        GenerarNumerosAleatorios();
    }

    void GenerarNumerosAleatorios()
    {
        System.Random rand = new System.Random();
        int numero = 0;

        do
        {
            numero = rand.Next(1, 1001);
            Debug.Log("Número aleatorio: " + numero);
        }
        while (numero % 5 != 0);

        Debug.Log("Se generó un múltiplo de 5. Fin.");
    }
}
