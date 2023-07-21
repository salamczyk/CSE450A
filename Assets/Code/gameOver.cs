using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public winTimer WinTimer;
    public static bool gameOverSetup = false;
    // public Text levelText;
    public void Setup(/*int level*/)
    {
        gameObject.SetActive(true);
        WinTimer.timeToWin = 1000f;
        gameOverSetup = true;
        //levelText.text = 
    }
    public void RestartButton()
    {
        //SceneManager.LoadScene("MainScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
