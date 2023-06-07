using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input4 : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;  
    [SerializeField] private Transform respawnPoint;  

    private Rigidbody rb;  
    private Vector3 movement;  

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        movement = new Vector3(horizontalInput, 0f, verticalInput);
        movement.Normalize();  

        Vector3 newPosition = rb.position + movement * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);

        if (rb.position.y < -20f)
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.position = respawnPoint.position;
    }
}
