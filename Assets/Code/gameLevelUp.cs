using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameLevelUp : MonoBehaviour
{
    // public Text levelText;
    public void Setup(/*int level*/)
    {
        if (!gameOver.gameOverSetup)
        {
            gameObject.SetActive(true);
        }
        //levelText.text = 
    }
    public void LevelUpButton()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        gameOver.gameOverSetup = false;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        //SceneManager.LoadScene("MainScene");
        SceneManager.LoadScene(nextSceneIndex);
    }
    
    public void RestartButton()
    {
        gameOver.gameOverSetup = false;
        //SceneManager.LoadScene("MainScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
