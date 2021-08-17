using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int playerLives;
    public string startLevel;

    public string levelSelect;

    public void NewGame()
    {
        PlayerPrefs.SetInt("PlayerCurrentLives", playerLives);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        


    }

    public void LevelSelect()
    {
        // SceneManager.LoadScene(levelSelect);
        // PlayerPrefs.SetInt("PlayerCurrentLives", playerLives);

    }
    
    public void QuitGame()
    {
        Application.Quit();

    }
    
}
