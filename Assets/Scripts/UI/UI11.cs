using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI11 : MonoBehaviour
{
    public GameObject cube;

    public void MoveLeft()
    {
        cube.transform.Translate(Vector3.left);
    }

    public void MoveRight()
    {
        cube.transform.Translate(Vector3.right);
    }

    public void MoveUp()
    {
        cube.transform.Translate(Vector3.up);
    }

    public void MoveDown()
    {
        cube.transform.Translate(Vector3.down);
    }

    public void ScaleUp()
    {
        cube.transform.localScale += Vector3.one * 0.1f;
    }

    public void ScaleDown()
    {
        cube.transform.localScale -= Vector3.one * 0.1f;
    }
}
