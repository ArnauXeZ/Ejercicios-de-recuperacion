using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    public int animationIndex;

    public void NextAnimation()
    {
        animationIndex++;
        animator.SetInteger("AnimationIndex", animationIndex);
    }

    public void PreviousAnimation()
    {
        if (animationIndex > 0)
        {
            animationIndex--;
        }
        animator.SetInteger("AnimationIndex", animationIndex);
    }

    public void RandomAnimation()
    {
        animationIndex = Random.Range(0, 3);
        animator.SetInteger("AnimationIndex", animationIndex);
    }
}
