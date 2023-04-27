using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion20 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AumentarEscala();
        }
    }

    void AumentarEscala()
    {
        transform.localScale += new Vector3(1, 1, 1);
    }
}
