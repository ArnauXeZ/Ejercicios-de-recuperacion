using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutina3 : MonoBehaviour
{
    public Transform cylinderTransform;
    public Vector3[] positions;
    public float speed = 1f;

    private int currentPositionIndex = 0;

    private void Start()
    {
        StartCoroutine(MoveCylinder());
    }

    private IEnumerator MoveCylinder()
    {
        while (currentPositionIndex < positions.Length)
        {
            Vector3 targetPosition = positions[currentPositionIndex];
            float distance = Vector3.Distance(cylinderTransform.position, targetPosition);

            while (distance > 0.01f)
            {
                cylinderTransform.position = Vector3.MoveTowards(cylinderTransform.position, targetPosition, speed * Time.deltaTime);
                distance = Vector3.Distance(cylinderTransform.position, targetPosition);
                yield return null;
            }

            currentPositionIndex++;
        }
    }
}
