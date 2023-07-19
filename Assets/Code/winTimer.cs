using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class winTimer : MonoBehaviour
{
    // Configuration
    public float timeToWin;
    public TextMeshProUGUI currentTimeText;
    public gameLevelUp gameLevelUp;
    
    
    // State Tracking
    private bool playerWon = false;
    private bool playerLose = false;

    private bool passOnce = false;
    // Update is called once per frame
    void Update()
    {
        if (passOnce)
        {
            if (timeToWin == 1000f)
            {
                currentTimeText.text = "";
                playerLose = true;
            }
            if (timeToWin <= 0)
            {
                timeToWin = 0;
                playerWon = true;
                gameLevelUp.Setup();
            }
            if (playerWon == false && playerLose == false)
            {
                string timeString = timeToWin.ToString("F2");
                currentTimeText.text = timeString.Replace(".", ":");
                timeToWin -= Time.deltaTime;
            }
        }
        else
        {
            passOnce = true;
        }

    }
}
