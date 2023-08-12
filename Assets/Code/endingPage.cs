using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endingPage : MonoBehaviour
{
    public void LevelSelection()
    {
        gameOver.gameOverSetup = false;
        SceneManager.LoadScene("ChapterPage");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
