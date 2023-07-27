using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorNextLevel : MonoBehaviour
{
    public gameLevelUp gameLevelUp;
    public gameOver gameOver;
    public float winTimer = 0f;
    private float onethird;
    private float twothird;

    public GameObject star_1;
    public GameObject star_2;
    public GameObject star_3;

    private void Start()
    {
        onethird = winTimer / 3;
        twothird = 2 * winTimer / 3;
    }
    private void Update()
    {
        winTimer -= Time.deltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<playerController>() != null)
        {
            if(winTimer > twothird)
            {
                star_1.SetActive(true);
                star_2.SetActive(true);
                star_3.SetActive(true);
            }
            else if (winTimer > onethird)
            {
                star_1.SetActive(true);
                star_2.SetActive(true);
            }
            else if (winTimer > 0)
            {
                star_1.SetActive(true);
            }
            gameLevelUp.Setup();
        }
    }
}
