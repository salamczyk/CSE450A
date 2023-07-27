using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorControl : MonoBehaviour
{
    public SKFDoor door;
    public GameObject key;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<playerController>() != null)
        {
            door.OpenDoor();
            key.SetActive(false);
        }
    }
}
