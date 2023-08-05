using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chapterPage : MonoBehaviour
{
    public int level;
    
    public void OpenScene()
    {
        if (level == 0)
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
            SceneManager.LoadScene("Scene_" + level.ToString());
        }
        
    }

}
