using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle5 : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}
