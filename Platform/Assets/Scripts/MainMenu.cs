using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public string startLevel;

    public string levelSelect;

    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(levelSelect);

    }
    
    public void QuitGame()
    {
        Application.Quit();

    }
    
}
