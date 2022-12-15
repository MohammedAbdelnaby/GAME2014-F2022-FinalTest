using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkingPlatformController : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
            animator.SetBool("Shrink", true);
    }

    public void ShrinkDone()
    {
        animator.SetBool("Shrink", false);
    }
}

