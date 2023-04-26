using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionFunciones : MonoBehaviour
{
    //5
    public bool EsPar(int num)
    {
        if (num % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
