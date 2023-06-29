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
    
    // Update is called once per frame
    void Update()
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
            currentTimeText.text = timeToWin.ToString();
            timeToWin -= Time.deltaTime;
        }

    }
}
