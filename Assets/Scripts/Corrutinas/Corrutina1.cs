using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutina1 : MonoBehaviour
{
    public Material sphereMaterial;
    public bool gameOver = false;

    private void Start()
    {
        StartCoroutine(ChangeSphereColor());
    }

    private IEnumerator ChangeSphereColor()
    {
        while (!gameOver)
        {
            Color randomColor = Random.ColorHSV();
            sphereMaterial.color = randomColor;
            yield return new WaitForSeconds(1f);
        }
    }
}
