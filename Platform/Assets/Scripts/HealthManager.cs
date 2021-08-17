using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public int maxPlayerHealth;
    public static int playerHealth;

    TextMeshProUGUI text;

    private LevelManager levelManager;

    public bool isDead;

    private LifeManager lifeSystem;
   
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();

        playerHealth = maxPlayerHealth;

        levelManager = FindObjectOfType<LevelManager>();

        lifeSystem = FindObjectOfType<LifeManager>();

        isDead = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth <= 0 && !isDead)
        {
            playerHealth = 0;
            levelManager.RespawnPlayer();
            lifeSystem.TakeLife();
            isDead = true;
        }

        text.text = "" + playerHealth;
        
    }

    public static void HurtPlayer(int damageToGive)
    {
        playerHealth -= damageToGive;
    }

    public void FullHealth()
    {
        playerHealth = maxPlayerHealth;
    }
}
