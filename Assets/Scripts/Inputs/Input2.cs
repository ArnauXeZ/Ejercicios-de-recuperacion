using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input2 : MonoBehaviour
{
    public float speed = 5f; 
    public float screenLimit = 100f; 

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput);

        direction.Normalize();

        Vector3 movement = direction * speed * Time.deltaTime;

        Vector3 newPosition = transform.position + movement;

        newPosition.x = Mathf.Clamp(newPosition.x, -screenLimit, screenLimit);
        newPosition.z = Mathf.Clamp(newPosition.z, -screenLimit, screenLimit);

        transform.position = newPosition;
    }
}
