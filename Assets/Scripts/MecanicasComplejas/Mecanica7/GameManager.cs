using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int puntos = 0;
    public int vidas = 3;

    public Text puntosText;
    public Text vidasText;

    private GameObject player;
    private GameObject[] enemigos;
    private GameObject[] monedas;
    private GameObject[] powerups;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemigos = GameObject.FindGameObjectsWithTag("Enemigo");
        monedas = GameObject.FindGameObjectsWithTag("Moneda");
        powerups = GameObject.FindGameObjectsWithTag("Powerup");
    }

    private void Update()
    {
        puntosText.text = "Puntos: " + puntos;
        vidasText.text = "Vidas: " + vidas;
    }

    public void IncrementarPuntos()
    {
        puntos++;
    }

    public void IncrementarVidas()
    {
        vidas++;
    }

    public void DecrementarVidas()
    {
        vidas--;
    }
}
