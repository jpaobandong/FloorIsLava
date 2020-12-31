using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void QuitGame() {
        Application.Quit();
    }

    public void StartGame()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if(currentScene == 0)
        {
            SceneManager.LoadScene("Level 1");
        }
        else
        {
            int lastLevel = PlayerPrefs.GetInt("currentLevel");
            SceneManager.LoadScene(lastLevel);
        }
        
    }

    public void RestartLevel()
    {
        
    }
}
