using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePickUp : MonoBehaviour
{

    private LifeManager lifeSystem;
    // Start is called before the first frame update
    void Start()
    {
        lifeSystem = FindObjectOfType<LifeManager>();
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            lifeSystem.GiveLife();
            Destroy(gameObject);
        }
        
    }

    
}
