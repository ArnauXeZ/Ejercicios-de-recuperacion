using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI4 : MonoBehaviour
{
    public Image timerImage;
    public float totalTime = 10f;
    private float currentTime;
    private bool isTimerRunning;

    private void Start()
    {
        currentTime = totalTime;
        isTimerRunning = false;
    }

    public void StartTimer()
    {
        if (!isTimerRunning)
        {
            StartCoroutine(CountdownTimer());
            isTimerRunning = true;
        }
    }

    private System.Collections.IEnumerator CountdownTimer()
    {
        while (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            timerImage.fillAmount = currentTime / totalTime;
            yield return null;
        }

        isTimerRunning = false;
    }
}
