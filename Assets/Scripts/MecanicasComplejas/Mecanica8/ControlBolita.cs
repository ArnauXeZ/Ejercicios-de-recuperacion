using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBolita : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    public Vector3 respawnPosition = new Vector3(0f, 0f, 0f);

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
    }

    private void FixedUpdate()
    {
        if (transform.position.y < 0f)
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        transform.position = respawnPosition;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
