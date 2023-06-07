using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPanel : MonoBehaviour
{
    public ControlJugador controlJugador;

    public void CambiarColor()
    {
        controlJugador.CambiarColor();
    }

    public void CambiarColorSiguiente()
    {
        controlJugador.CambiarColorSiguiente();
    }

    public void CambiarColorAnterior()
    {
        controlJugador.CambiarColorAnterior();
    }
}

