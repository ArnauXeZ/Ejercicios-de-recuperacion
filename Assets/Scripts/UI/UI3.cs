using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI3 : MonoBehaviour
{
    public Text counterText;
    private int counter;

    private void Start()
    {
        counter = 0;
        UpdateCounterText();
    }

    public void IncreaseCounter()
    {
        counter++;
        UpdateCounterText();
    }

    public void DecreaseCounter()
    {
        counter--;
        UpdateCounterText();
    }

    private void UpdateCounterText()
    {
        counterText.text = "Counter: " + counter.ToString();
    }
}
