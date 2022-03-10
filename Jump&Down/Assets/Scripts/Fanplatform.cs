using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fanplatform : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            // animator.Play("Fan_run");
            animator.SetBool("isonfan", true);
        }

    }

    // private void OnCollisionExit2D(Collision2D col)
    // {
    //     animator.SetBool("isonfan", false);
    // }
}
