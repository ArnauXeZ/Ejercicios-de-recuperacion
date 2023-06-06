using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion11 : MonoBehaviour
{
    [SerializeField] private bool gameOver = false; 

    
    void ComprobarGameOver()
    {
        if (!gameOver)
        {
            Debug.Log("Seguimos vivos");
        }
        else
        {
            Debug.Log("GAME OVER");
        }
    }

    
    void Start()
    {
        ComprobarGameOver();
    }
}
