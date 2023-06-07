using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour
{
    public Transform cannonPivot;
    public GameObject bulletPrefab;
    public float rotationSpeed = 10f;

    private void Update()
    {
        cannonPivot.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireBullet();
        }
    }

    private void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, cannonPivot.position, cannonPivot.rotation);

        Destroy(bullet, 5f);
    }
}
