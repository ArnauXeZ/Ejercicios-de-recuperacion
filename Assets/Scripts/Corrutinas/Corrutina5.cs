using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutina5 : MonoBehaviour
{
    public Transform cubeTransform;
    public KeyCode stopKey = KeyCode.Return;

    private Coroutine rotationCoroutine;

    private void Start()
    {
        rotationCoroutine = StartCoroutine(RotateCube());
    }

    private IEnumerator RotateCube()
    {
        while (true)
        {
            cubeTransform.Rotate(Vector3.up, 20f);
            yield return new WaitForSeconds(0.5f);

            if (Input.GetKeyDown(stopKey))
            {
                StopCoroutine(rotationCoroutine);
                yield break; 
            }
        }
    }
}
