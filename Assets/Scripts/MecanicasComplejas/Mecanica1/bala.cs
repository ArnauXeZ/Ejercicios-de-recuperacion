using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public float speed = 10f;

    private void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
}
