using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorInner : MonoBehaviour
{
    public gameLevelUp gameLevelUp;
    public void Setup()
    {
        gameObject.SetActive(true);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<playerController>() != null)
        {
            gameLevelUp.Setup();
        }
    }
}
