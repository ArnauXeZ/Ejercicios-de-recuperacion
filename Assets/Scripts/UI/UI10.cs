using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI10 : MonoBehaviour
{
    public GameObject cylinder;

    public void MoveUp()
    {
        cylinder.transform.Translate(Vector3.up);
    }

    public void MoveDown()
    {
        cylinder.transform.Translate(Vector3.down);
    }

    public void RotateClockwise()
    {
        cylinder.transform.Rotate(Vector3.left, 45f);
    }

    public void RotateCounterclockwise()
    {
        cylinder.transform.Rotate(Vector3.left, -45f);
    }

    public void ScaleUp()
    {
        cylinder.transform.localScale += Vector3.one * 0.1f;
    }

    public void ScaleDown()
    {
        cylinder.transform.localScale -= Vector3.one * 0.1f;
    }

    public void ResetPosition()
    {
        cylinder.transform.position = Vector3.zero;
    }
}
