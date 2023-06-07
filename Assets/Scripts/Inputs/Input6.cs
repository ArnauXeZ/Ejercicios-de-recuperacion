using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input6 : MonoBehaviour
{
    public float rotationSpeed = 100f;  

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        float rotationDirection = 0f;
        if (horizontalInput > 0)
        {
            rotationDirection = 1f;  
        }
        else if (horizontalInput < 0)
        {
            rotationDirection = -1f;  
        }

        transform.Rotate(Vector3.up, rotationDirection * rotationSpeed * Time.deltaTime);
    }
}
