using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion21 : MonoBehaviour
{     
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ReducirEscala();
            }
        }

        void ReducirEscala()
        {
            if (transform.localScale.x > 1 && transform.localScale.y > 1 && transform.localScale.z > 1)
            {
                transform.localScale -= new Vector3(1, 1, 1);
            }
        }
    
}
