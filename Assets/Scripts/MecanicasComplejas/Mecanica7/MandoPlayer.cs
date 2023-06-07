using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MandoPlayer : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody rb;
    private GameManager gameManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
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
        if (other.CompareTag("Enemigo"))
        {
            gameManager.DecrementarVidas();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Moneda"))
        {
            gameManager.IncrementarPuntos();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Powerup"))
        {
            gameManager.IncrementarVidas();
            Destroy(other.gameObject);
        }
    }
}
