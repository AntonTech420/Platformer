using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhealth : MonoBehaviour
{

    public int enemyHealth;
    AudioSource _audio;

    public GameObject deatheffect;
    public int pointsOnDeath;
    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHealth <= 0)
        {
            Instantiate(deatheffect, transform.position, transform.rotation);
            
            ScoreManager.AddPoints(pointsOnDeath);
            Destroy(gameObject);
        }
        
    }

    public void giveDamage(int damageToGive)
    {
        enemyHealth -= damageToGive;
        // _audio.Play();

    }
}
