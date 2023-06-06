using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion20 : MonoBehaviour
{
    
    void Reducir()
    {
        
        if (transform.localScale.x > 1f && transform.localScale.y > 1f && transform.localScale.z > 1f)
        {
            transform.localScale -= new Vector3(1f, 1f, 1f);
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Reducir();
        }
    }
}
