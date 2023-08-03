using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereShower : MonoBehaviour
{

    public float start = 0.0f;
    public float end = 100.0f;
    public float spawnRate;

    private float timer;

    public int x = 1;
    public int y = 1;
    public GameObject sphere;
    private float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > start && timer < end)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - Time.deltaTime;
            }
            else
            {
                for (int i = 0; i <= x; i++)
                {
                    for (int j = 0; j <= y; j++)
                    {
                        GameObject newSphere = Instantiate(sphere);
                        Vector3 position = this.transform.position;
                        position.x = position.x + i;
                        position.z = position.z + j;
                        newSphere.transform.position = position;

                    }
                }
                timeLeft = spawnRate;
            }
           
        }
    }
}
