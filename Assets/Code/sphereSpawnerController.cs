using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereSpawnerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    public float spawnRate;
    public float speed;
    public float start;
    public float end;

    private float timer;
    private float timeLeft;
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > start && timer < end)
            {
                if (timeLeft > 0)
                {
                    timeLeft = timeLeft - Time.deltaTime;
                }
                else
                {
                    float xRotation = Random.Range(0f, 1f) * 360;
                    float yRotation = Random.Range(0f, 1f) * 360;
                    float zRotation = Random.Range(0f, 1f) * 360;
                    xRotation = xRotation * Mathf.Deg2Rad;
                    yRotation = yRotation * Mathf.Deg2Rad;
                    zRotation = zRotation * Mathf.Deg2Rad;


                    GameObject newSphere = Instantiate(sphere);
                    newSphere.transform.position = this.transform.position;
                    Rigidbody _rb = newSphere.GetComponent<Rigidbody>();
                    _rb.AddForce(speed * Mathf.Cos(xRotation), speed * Mathf.Cos(yRotation), speed * Mathf.Cos(zRotation));

                    timeLeft = spawnRate;
                }
            }
    }
}
