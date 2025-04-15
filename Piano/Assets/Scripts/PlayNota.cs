using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNota : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;
    private KeyCode keyCode;

    private bool isPlaying = false;
    private bool isStoped = true;


    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        audioSource = GetComponentInChildren<AudioSource>();
        keyCode = GetComponentInChildren<NotaScript>().key;
    }

    
    void Update()
    {
        if (Input.GetKeyDown (keyCode) && isStoped)
        {
            isStoped = false;
            isPlaying = true;
            audioSource.Play();
            animator.SetTrigger("Press");

        }

        if (Input.GetKeyUp (keyCode) && isPlaying)
        {
            isPlaying = false;
            isStoped = true;
            audioSource.Stop();
            animator.SetTrigger("Release");
        }
    }
}
