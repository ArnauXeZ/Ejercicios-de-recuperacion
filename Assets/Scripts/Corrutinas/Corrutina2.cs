using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutina2 : MonoBehaviour
{
    public Transform cubeTransform;
    public bool gameOver = false;

    private void Start()
    {
        StartCoroutine(ScaleCube());
    }

    private IEnumerator ScaleCube()
    {
        while (!gameOver)
        {
            Vector3 randomScale = GetRandomScale();
            cubeTransform.localScale = randomScale;
            yield return new WaitForSeconds(2f);
        }
    }

    private Vector3 GetRandomScale()
    {
        float randomScaleX = Random.Range(0.5f, 2f);
        float randomScaleY = Random.Range(0.5f, 2f);
        float randomScaleZ = Random.Range(0.5f, 2f);
        return new Vector3(randomScaleX, randomScaleY, randomScaleZ);
    }
}
