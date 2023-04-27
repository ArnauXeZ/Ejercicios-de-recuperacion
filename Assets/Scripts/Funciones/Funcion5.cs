using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Funcion5 : MonoBehaviour
{
    bool EsBisiesto(int anio)
    {
        return DateTime.IsLeapYear(anio);
    }
}
