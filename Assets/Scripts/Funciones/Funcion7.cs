using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Funcion7 : MonoBehaviour
{
    int ObtenerDiasDelMes(string mes)
    {
        string fechaString = "01 " + mes + " " + DateTime.Now.Year.ToString();
        DateTime fecha = DateTime.ParseExact(fechaString, "dd MMMM yyyy", CultureInfo.InvariantCulture);
        int diasDelMes = DateTime.DaysInMonth(fecha.Year, fecha.Month);
        return diasDelMes;
    }

}
