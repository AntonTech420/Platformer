using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    private Rigidbody2D rb;

    public float speed;
    public GameObject enemyDeatheffect;
    public GameObject wallBullet;

    // public AudioSource[] sounds;
    // public AudioSource noise;
    public PlayerController player;

    public int bulletDamage;

    public int pointsForKill;
    // Start is called before the first frame update
    void Start()
    {
        // sounds = GetComponents<AudioSource>();
        // noise = sounds[1];
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerController>();

        if(player.transform.localScale.x < 0)
            speed = -speed;
        
    }

    // Update is called once per frame
    void Update()
    {
       rb.velocity = new Vector2(speed, rb.velocity.y); 
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Enemy")
        {

            // Instantiate(enemyDeatheffect, other.transform.position, other.transform.rotation);
            // Destroy(other.gameObject);
            // ScoreManager.AddPoints(pointsForKill);
            other.GetComponent<Enemyhealth>().giveDamage(bulletDamage);

        }
        Instantiate(wallBullet, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    
}
