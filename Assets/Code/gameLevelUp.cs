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
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 1;
        }
        if (nextSceneIndex > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", nextSceneIndex);
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
            nextSceneIndex = 1;
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

    public void LevelSelection()
    {
        gameOver.gameOverSetup = false;
        SceneManager.LoadScene("ChapterPage");
    }
}
