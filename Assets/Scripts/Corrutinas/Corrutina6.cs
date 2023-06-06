using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Corrutina6 : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public string message = "hola que tal?";

    private void Start()
    {
        StartCoroutine(ShowLetters());
    }

    private IEnumerator ShowLetters()
    {
        int currentIndex = 0;

        while (currentIndex < message.Length)
        {
            textMeshPro.text += message[currentIndex];
            currentIndex++;

            yield return new WaitForSeconds(0.2f);
        }
    }
}
