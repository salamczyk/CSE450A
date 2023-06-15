using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sphereController : MonoBehaviour
{
    public float xOffset;
    public float yOffset;
    public float zOffset;
    private Vector3 initPos;

    private float xSpeed;
    private float ySpeed;
    private float zSpeed;

    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.position;
        
        xSpeed = xOffset;
        ySpeed = yOffset;
        zSpeed = zOffset;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;

        currentPos.x += xSpeed * Time.deltaTime;
        currentPos.y += ySpeed * Time.deltaTime;
        currentPos.z += zSpeed * Time.deltaTime;
        
        transform.position = currentPos;

    }

    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
