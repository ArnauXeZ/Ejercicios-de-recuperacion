using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input5 : MonoBehaviour
{
    public float rotationSpeed = 100f; 

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
