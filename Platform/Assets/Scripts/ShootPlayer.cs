using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{

    public float playerRange;
    public GameObject enemyBullet;
    public PlayerController player;
    public Transform firePoint;
    public float waitBetweenShots;
    private float shotCounter;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        shotCounter = waitBetweenShots;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector3(transform.position.x -playerRange, transform.position.y, transform.position.z),new Vector3(transform.position.x +playerRange, transform.position.y, transform.position.z));
        shotCounter -= Time.deltaTime;

        if(transform.localScale.x < 0 && player.transform.position.x > transform.position.x && player.transform.position.x < transform.position.x + playerRange && shotCounter < 0)
        {
            Instantiate(enemyBullet, firePoint.position, firePoint.rotation);
            shotCounter = waitBetweenShots;
        }
        if(transform.localScale.x > 0 && player.transform.position.x < transform.position.x && player.transform.position.x > transform.position.x - playerRange && shotCounter < 0)
        {
            Instantiate(enemyBullet, firePoint.position, firePoint.rotation);
            shotCounter = waitBetweenShots;
        }
    }
}
