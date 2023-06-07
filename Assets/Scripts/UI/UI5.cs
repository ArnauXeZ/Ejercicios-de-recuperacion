using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI5 : MonoBehaviour
{
    public Slider slider;
    public Image filledImage;

    private void Start()
    {
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
        filledImage.fillAmount = value;
    }
}
