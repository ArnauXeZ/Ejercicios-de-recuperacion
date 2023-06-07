using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI12 : MonoBehaviour
{
    private Button button;
    private Coroutine colorChangeCoroutine;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
        colorChangeCoroutine = StartCoroutine(ChangeColorRoutine());
    }

    private void OnDestroy()
    {
        if (colorChangeCoroutine != null)
        {
            StopCoroutine(colorChangeCoroutine);
        }
    }

    public void OnButtonClick()
    {
        if (colorChangeCoroutine != null)
        {
            StopCoroutine(colorChangeCoroutine);
        }
    }

    private IEnumerator ChangeColorRoutine()
    {
        while (true)
        {
            Color newColor = new Color(Random.value, Random.value, Random.value);
            button.image.color = newColor;
            yield return new WaitForSeconds(1f);
        }
    }
}
