using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject); 
        WaveManager.Instance.EnemyDestroyed();
    }
}
