using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanica2 : MonoBehaviour
{
    public AudioClip[] soundEffects;
    public Color[] colors;

    private AudioSource audioSource;
    private Camera mainCamera;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayRandomSoundEffect();
            ChangeBackgroundColor();
            ChangeCameraClearFlags();
        }
    }

    private void PlayRandomSoundEffect()
    {
        if (soundEffects.Length > 0)
        {
            int randomIndex = Random.Range(0, soundEffects.Length);
            audioSource.clip = soundEffects[randomIndex];
            audioSource.Play();
        }
    }

    private void ChangeBackgroundColor()
    {
        if (colors.Length > 0)
        {
            int randomIndex = Random.Range(0, colors.Length);
            mainCamera.backgroundColor = colors[randomIndex];
        }
    }

    private void ChangeCameraClearFlags()
    {
        mainCamera.clearFlags = CameraClearFlags.SolidColor;
    }
}
