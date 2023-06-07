using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveManager : MonoBehaviour
{
    public static WaveManager Instance; 

    public GameObject enemyPrefab; 
    public Text waveText; 

    private int currentWave = 1; 
    private int enemiesRemaining; 

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        StartWave();
    }

    private void StartWave()
    {
        enemiesRemaining = currentWave;
        waveText.text = "Wave: " + currentWave.ToString();

        for (int i = 0; i < enemiesRemaining; i++)
        {
            Instantiate(enemyPrefab, GetRandomPosition(), Quaternion.identity);
        }
    }

    private Vector3 GetRandomPosition()
    {
        
        float x = Random.Range(-10f, 10f);
        float y = 0f;
        float z = Random.Range(-10f, 10f);

        return new Vector3(x, y, z);
    }

    public void EnemyDestroyed()
    {
        enemiesRemaining--;

        if (enemiesRemaining <= 0)
        {
            currentWave++;
            StartWave();
        }
    }
}
