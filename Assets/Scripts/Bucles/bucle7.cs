using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle7 : MonoBehaviour
{
    void Start()
    {
        for (int i = 100; i <= 200; i++)
        {
            if (i % 5 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}
