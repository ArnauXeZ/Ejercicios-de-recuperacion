using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion11 : MonoBehaviour
{
    public void ComprobarGameOver()
    {
        bool gameOver = false; // Puedes cambiar esto para probar el comportamiento de la funci�n
        if (!gameOver)
        {
            Debug.Log("Seguimos vivos");
        }
        else
        {
            Debug.Log("GAME OVER");
        }
    }
}
