using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI6 : MonoBehaviour
{
    public Slider slider;
    public GameObject targetObject;

    private Renderer targetRenderer;
    private Material targetMaterial;

    private void Start()
    {
       
        targetRenderer = targetObject.GetComponent<Renderer>();

      
        targetMaterial = targetRenderer.material;

      
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
       
        Color color = targetMaterial.color;

        
        color.a = value;

       
        targetMaterial.color = color;
    }
}
