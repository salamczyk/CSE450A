using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sphereController : MonoBehaviour
{
    Rigidbody rb;

    public gameOver gameOver;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        if(collision.gameObject.layer == 9)
        {
            Destroy(gameObject);
        }
    }
}
