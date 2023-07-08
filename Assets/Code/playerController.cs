using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;
//using UnityEngine.Windows.Speech;

public class playerController : MonoBehaviour
{
    Rigidbody _rb;
    
    public gameOver gameOver;

    public float movementSpeed;

    public float mouseSensitivity;

    public int jumpsLeft;

    //public float rotationSpeed;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.useGravity = true;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            //transform.position += new Vector3(0, 0, -movementSpeed * Time.deltaTime);
            _rb.AddRelativeForce(Vector3.back * movementSpeed * Time.deltaTime, ForceMode.Impulse);
            //transform.rotation = Quaternion.LookRotation(new Vector3(0, 0, -1));
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            //transform.position += new Vector3(0, 0, movementSpeed * Time.deltaTime);
            _rb.AddRelativeForce(Vector3.forward * movementSpeed * Time.deltaTime, ForceMode.Impulse);
            //transform.rotation = Quaternion.LookRotation(new Vector3(0, 0, 1));
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position += new Vector3(-movementSpeed * Time.deltaTime, 0, 0);
            _rb.AddRelativeForce(Vector3.left * movementSpeed * Time.deltaTime, ForceMode.Impulse);
            //transform.rotation = Quaternion.LookRotation(new Vector3(-1, 0, 0));
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            // transform.position += new Vector3(movementSpeed * Time.deltaTime, 0, 0);
            _rb.AddRelativeForce(Vector3.right * movementSpeed * Time.deltaTime, ForceMode.Impulse);
            //transform.rotation = Quaternion.LookRotation(new Vector3(1, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpsLeft > 0)
            {
                jumpsLeft--;
                
                _rb.AddForce(Vector3.up*800f, ForceMode.Impulse);
                
            }
            
        }
        transform.Rotate(0, mouseSensitivity * Input.GetAxis("Mouse X"), 0);
        if (_rb.position.y <= -5f)
        {
            gameOver.Setup();
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            jumpsLeft = 2;
        }
    }


}
