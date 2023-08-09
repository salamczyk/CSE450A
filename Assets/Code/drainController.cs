using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drainController : MonoBehaviour
{
    public float start;
    public float end;
    private float timer;
    // Start is called before the first frame update
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
            if (gameObject.layer != 9)
            {
                gameObject.layer = 9;
            }
            Debug.Log("here");
        }
        else
        {
            if (gameObject.layer != 0)
            {
                gameObject.layer = 0;
            }
        }
    }
}
