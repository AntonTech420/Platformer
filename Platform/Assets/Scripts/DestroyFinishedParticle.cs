using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFinishedParticle : MonoBehaviour
{

   public float timer = 5.0f;

    private ParticleSystem thisParticleSystem;
    // Start is called before the first frame update
    void Start()
    {
        thisParticleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
      timer -= 1*Time.deltaTime;
      if(timer <= 0)
      {
        Destroy(gameObject); 
      }
     if(thisParticleSystem.isPlaying)
        return;

      // Destroy(gameObject);     
    }

    // void OnBecameInvisible() 
    // {
    //  Destroy(gameObject);   
    // }
}
