using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion18 : MonoBehaviour
{
    public void DesplazarEnDireccion(Vector3 direccion)
    {
        transform.position += direccion;
    }
}
