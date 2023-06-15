using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class animationController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("IsRunning", true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("IsJumping", true);
            }
            else
            {
                animator.SetBool("IsJumping", false);
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("IsRunning", true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("IsJumping", true);
            }
            else
            {
                animator.SetBool("IsJumping", false);
            }
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("IsRunning", true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("IsJumping", true);
            }
            else
            {
                animator.SetBool("IsJumping", false);
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("IsRunning", true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("IsJumping", true);
            }
            else
            {
                animator.SetBool("IsJumping", false);
            }
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
            animator.SetBool("IsJumping", false);
        } 
    }
}

