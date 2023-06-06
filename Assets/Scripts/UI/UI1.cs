using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI1 : MonoBehaviour
{
    public GameObject panel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            panel.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}
