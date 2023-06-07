using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input1 : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput);

        direction.Normalize();

        Vector3 movement = direction * speed * Time.deltaTime;

        transform.Translate(movement);
    }
}
