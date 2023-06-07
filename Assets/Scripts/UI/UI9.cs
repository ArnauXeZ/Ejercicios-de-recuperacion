using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI9 : MonoBehaviour
{
    public Transform target;
    public float moveAmount = 1f;
    public float scaleAmount = 0.1f;

    public void MoveRight()
    {
        target.Translate(Vector3.right * moveAmount);
    }

    public void ScaleUp()
    {
        target.localScale += new Vector3(scaleAmount, scaleAmount, scaleAmount);
    }

    public void ScaleDown()
    {
        target.localScale -= new Vector3(scaleAmount, scaleAmount, scaleAmount);
    }

    public void MoveLeft()
    {
        target.Translate(Vector3.left * moveAmount);
    }

    public void MoveUp()
    {
        target.Translate(Vector3.up * moveAmount);
    }
}
