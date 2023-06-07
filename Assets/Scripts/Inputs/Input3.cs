using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input3 : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;  

    private Rigidbody rb;  
    private Vector3 movement;  

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;  
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        movement = new Vector3(horizontalInput, 0f, verticalInput);
        movement.Normalize();  

        Vector3 newPosition = rb.position + movement * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
    }
}
