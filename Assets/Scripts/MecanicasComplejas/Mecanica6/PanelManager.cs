using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject panel;

    private static PanelManager instance;

    public static PanelManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<PanelManager>();
            return instance;
        }
    }

    private void Start()
    {
        panel.SetActive(false);
    }

    public void MostrarPanel()
    {
        panel.SetActive(true);
    }

    public void OcultarPanel()
    {
        panel.SetActive(false);
    }
}
