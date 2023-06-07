using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI7 : MonoBehaviour
{
    public ParticleSystem particleSystem;
    private Button startButton;
    private Button stopButton;

    private void Start()
    {
        startButton = GameObject.Find("StartButton").GetComponent<Button>();
        startButton.onClick.AddListener(StartParticleSystem);

        stopButton = GameObject.Find("StopButton").GetComponent<Button>();
        stopButton.onClick.AddListener(StopParticleSystem);

        particleSystem.Stop(); 
    }

    private void StartParticleSystem()
    {
        particleSystem.Play(); 
    }

    private void StopParticleSystem()
    {
        particleSystem.Stop();
    }
}
