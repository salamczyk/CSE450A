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
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("IsRunning", true);
            // Other movement logic...
        }
        else
        {
            animator.SetBool("IsRunning", false);
            // Other movement logic...
        } 
    }
}

