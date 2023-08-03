using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuPage : MonoBehaviour
{
    
    public void StartButton()
    {
        SceneManager.LoadScene("ChapterPage");
        PlayerPrefs.DeleteAll();
        //SceneManager.LoadScene("Scene_2");
    }
}
