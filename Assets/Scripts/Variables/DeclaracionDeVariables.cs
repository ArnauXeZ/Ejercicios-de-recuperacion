using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    //1
    public int points;
    //2
    private float speed = 1.5f;
    //3
    [SerializeField] private bool isGameOver = false;
    //4
    public string mensaje = "¡Bienvenido!";
}
