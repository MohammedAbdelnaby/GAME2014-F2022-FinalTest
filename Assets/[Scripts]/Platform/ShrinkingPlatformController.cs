using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkingPlatformController : MonoBehaviour
{
    private Animator animator;
    private AudioSource soundShrink;
    private AudioSource soundGrow;


    private void Start()
    {
        animator = GetComponent<Animator>();
        soundShrink = GetComponents<AudioSource>()[0];
        soundGrow = GetComponents<AudioSource>()[1];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            animator.SetBool("Shrink", true);
        }
    }

    public void ShrinkDone()
    {
        animator.SetBool("Shrink", false);
    }

    public void PlayGrowSound()
    {
        soundGrow.Play();
    }

    public void PlayShrinkSound()
    {
        soundShrink.Play();
    }
}

