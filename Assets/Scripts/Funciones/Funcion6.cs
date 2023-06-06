using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion6 : MonoBehaviour
{
    [SerializeField] private int diaPrueba = 4;


    bool PerteneceAlFinDeSemana(int dia)
    {
        return dia == 6 || dia == 7;
    }


    void Start()
    {
        bool perteneceAlFinDeSemana = PerteneceAlFinDeSemana(diaPrueba);

        if (perteneceAlFinDeSemana)
        {
            Debug.Log("El d�a " + diaPrueba + " pertenece al fin de semana.");
        }
        else
        {
            Debug.Log("El d�a " + diaPrueba + " no pertenece al fin de semana.");
        }
    }
}