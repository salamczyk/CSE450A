using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKFDoor : MonoBehaviour
{
    //
    //   Package By ==================================== https://www.Sketchoverflow.com
    //   Download Link ================================= https://www.sketchoverflow.com/product/wooden-doors-unity-package-with-animation-audio
    //   Download Only 3D Models ======================= https://www.sketchoverflow.com/product/wooden-door-3d-model/
    //   Download More Free Original Unity Package ===== https://www.sketchoverflow.com/product-category/unity-package/
    //
    //Set the default status of the door here.
    public bool isOpen = false;

    public Animator animator;

    public AudioSource audioSource;
    public AudioClip clipOpen;
    public AudioClip clipClose;

    void Update()
    {
        // The Demo Code Used To Open And Close Doors
        //if(Input.GetKeyDown(KeyCode.F))
        //{
        //    ChangeDoorStatus();
        //}
    }
    public void ChangeDoorStatus() //Open door if it's closed, Close door if it's open.
    {
        if(isOpen)
        {
            CloseDoor();
        }
        else
        {
            OpenDoor();
        }
    }
    public void OpenDoor()
    {
        if (!isOpen)
        {
            audioSource.clip = clipOpen;
            audioSource.Play();
            animator.SetBool("Open", true);
            isOpen = true;
        }
    }
    public void CloseDoor()
    {
        if (isOpen)
        {
            audioSource.clip = clipClose;
            audioSource.Play();
            animator.SetBool("Open", false);
            isOpen = false;
        }
    }
}
