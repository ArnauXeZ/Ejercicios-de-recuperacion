using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle29 : MonoBehaviour
{
    public GameObject esferaPrefab;
    public Material[] materiales;

    void Start()
    {
        if (materiales.Length == 0)
        {
            Debug.LogError("Esta vacio.");
            return;
        }

        for (int i = 0; i < materiales.Length; i++)
        {
            
            Vector3 posicion = new Vector3(i * 2f, 0f, 0f);

            
            GameObject esfera = Instantiate(esferaPrefab, posicion, Quaternion.identity);

            
            Renderer renderer = esfera.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material = materiales[i % materiales.Length];
            }
        }
    }
}
