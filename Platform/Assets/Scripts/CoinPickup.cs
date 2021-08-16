using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    public GameObject cAuidio;
    public int pointsToAdd;

    void Start()
    {
        // _audio = GetComponent<AudioSource>();
        
    }


    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.GetComponent<PlayerController>() == null)
            return;
        ScoreManager.AddPoints(pointsToAdd);

        // _audio.Play();
        Instantiate(cAuidio, transform.position, transform.rotation);
        Destroy(gameObject);
    }


}
