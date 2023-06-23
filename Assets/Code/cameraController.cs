using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject character;
    private Vector3 initOffset;
    // Start is called before the first frame update
    void Start()
    {
        initOffset = character.transform.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = character.transform.position - initOffset;
    }
}
