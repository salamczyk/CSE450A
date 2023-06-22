using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sphereController : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 initForce;

    public gameOver gameOver;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(initForce);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<playerController>() != null)
        {
            gameOver.Setup();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }
}
