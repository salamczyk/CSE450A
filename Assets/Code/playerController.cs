using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody _rb;
    
    public float movementSpeed;
    //public float rotationSpeed;
    void Start()
    {
        //_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, -movementSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, movementSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-movementSpeed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(movementSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space) && transform.position.y == 0)
        {
            transform.position += new Vector3(0, 50 * movementSpeed * Time.deltaTime, 0);
        }
        
        else if(Input.GetKey(KeyCode.Space) == false)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        

        

    }
}
