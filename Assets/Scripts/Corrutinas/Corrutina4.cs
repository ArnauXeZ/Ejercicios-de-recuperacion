using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutina4 : MonoBehaviour
{
    public Transform cylinderTransform;
    public Vector3[] positions;
    public KeyCode stopKey = KeyCode.Space;

    private int currentPositionIndex = 0;

    private void Start()
    {
        StartCoroutine(MoveCylinder());
    }

    private IEnumerator MoveCylinder()
    {
        while (true)
        {
            Vector3 targetPosition = positions[currentPositionIndex];
            float duration = Random.Range(0.5f, 2.5f);
            float timeElapsed = 0f;

            while (timeElapsed < duration)
            {
                cylinderTransform.position = Vector3.Lerp(cylinderTransform.position, targetPosition, timeElapsed / duration);
                timeElapsed += Time.deltaTime;
                yield return null;
            }

            currentPositionIndex = (currentPositionIndex + 1) % positions.Length;

            if (Input.GetKeyDown(stopKey))
            {
                break;
            }
        }
    }
}
