using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle6 : MonoBehaviour
{
    void Start()
    {
        for (int i = 100; i >= 0; i--)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
    }
}
