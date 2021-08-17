using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    TextMeshProUGUI text;
    public int startingLives;
    private int lifeCounter;

    public GameObject GameOverScreen;

    public string mainMenu;
    public float waitAfterGameOver;

    public PlayerController player;

    private TextMeshProUGUI theText;
    // Start is called before the first frame update
    void Start()
    {
        theText = GetComponent<TextMeshProUGUI>();

        lifeCounter = startingLives /*PlayerPrefs.GetInt("PlayerCurrentLives")*/;

        player = FindObjectOfType<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeCounter < 0 )
        {
            GameOverScreen.SetActive(true);
            player.gameObject.SetActive(false);
        }
        theText.text = "x " + lifeCounter;

        if(GameOverScreen.activeSelf)
        {
            waitAfterGameOver -= Time.deltaTime;
        }

        if(waitAfterGameOver < 0)
        {
            SceneManager.LoadScene(mainMenu);
        }
        
    }

    public void GiveLife()
    {
        lifeCounter++;

    }

    public void TakeLife()
    {
        lifeCounter--;

    }
}
