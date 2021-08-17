using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;

    
    public GameObject wallBullet;

    // public AudioSource[] sounds;
    // public AudioSource noise;
    public PlayerController player;

    public int bulletDamage;

    
    void Start()
    {
        // sounds = GetComponents<AudioSource>();
        // noise = sounds[1];
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerController>();

        if(player.transform.position.x < transform.position.x)
            speed = -speed;
        
    }

    // Update is called once per frame
    void Update()
    {
       rb.velocity = new Vector2(speed, rb.velocity.y); 
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.name == "Player")
        {

            // Instantiate(enemyDeatheffect, other.transform.position, other.transform.rotation);
            // Destroy(other.gameObject);
            // ScoreManager.AddPoints(pointsForKill);
            HealthManager.HurtPlayer(bulletDamage);
            

        }
        Instantiate(wallBullet, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
