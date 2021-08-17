using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public string mainMenu;

    public bool isPaused;

    public GameObject PauseMenuCanvas;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            isPaused = !isPaused;

            Time.timeScale = isPaused ? 0f: 1f;

            PauseMenuCanvas.SetActive(isPaused);
        
        
    }

    public void Resume()
    {
        isPaused = false;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(mainMenu);

    }
}
