using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody rb;
    private Renderer jugadorRenderer;

    public Color[] colores;
    private int indiceColor;

    private bool enPlataforma = false;
    public GameObject panelOpciones;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jugadorRenderer = GetComponent<Renderer>();
        indiceColor = 0;
        CambiarColor();
    }

    private void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plataforma"))
        {
            enPlataforma = true;
            panelOpciones.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Plataforma"))
        {
            enPlataforma = false;
            panelOpciones.SetActive(false);
        }
    }

    public void CambiarColor()
    {
        jugadorRenderer.material.color = colores[indiceColor];
    }

    public void CambiarColorSiguiente()
    {
        if (enPlataforma)
        {
            indiceColor++;
            if (indiceColor >= colores.Length)
                indiceColor = 0;
            CambiarColor();
        }
    }

    public void CambiarColorAnterior()
    {
        if (enPlataforma)
        {
            indiceColor--;
            if (indiceColor < 0)
                indiceColor = colores.Length - 1;
            CambiarColor();
        }
    }
}

