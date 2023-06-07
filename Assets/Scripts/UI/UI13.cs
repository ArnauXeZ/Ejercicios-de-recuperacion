using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI13 : MonoBehaviour
{
    public GameObject spherePrefab;
    public Button placeSpheresButton;

    public Vector3[] positions; 

    private bool spheresPlaced = false; 

    private void Start()
    {
        placeSpheresButton.onClick.AddListener(PlaceSpheres);
    }

    private void Update()
    {
        if (spheresPlaced)
        {
            placeSpheresButton.interactable = false; 
        }
    }

    private void PlaceSpheres()
    {
        for (int i = 0; i < positions.Length; i++)
        {
            GameObject sphere = Instantiate(spherePrefab, positions[i], Quaternion.identity);         
        }

        spheresPlaced = true;
    }
}
