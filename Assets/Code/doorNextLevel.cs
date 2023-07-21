using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorNextLevel : MonoBehaviour
{
    public gameLevelUp gameLevelUp;
    public gameOver gameOver;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<playerController>() != null)
        {
            gameLevelUp.Setup();
        }
    }
}
