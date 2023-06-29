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
        gameObject.SetActive(true);
        //levelText.text = 
    }
    public void LevelUpButton()
    {
        //SceneManager.LoadScene("MainScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
