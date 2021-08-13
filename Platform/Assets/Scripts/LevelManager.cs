using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;
    private PlayerController player;

    public GameObject deathParticle;
    public GameObject respawnParticle;
    public float respawnDelay;

    public int pointPenalty;

    private float gravityStore;

    private Rigidbody2D myrigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
      player = FindObjectOfType<PlayerController>();
      myrigidbody2D = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
      StartCoroutine("RespawnPlayerCo");  
    }

    public IEnumerator RespawnPlayerCo()
    {
        Instantiate (deathParticle, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;

        // gravityStore = player.rigidbody2D.gravityScale;
        // player.rigidbody2D.gravityScale = 0f;


        player.GetComponent<Rigidbody2D>().velocity =  Vector2.zero;
        ScoreManager.AddPoints(-pointPenalty);
        Debug.Log("Player Res");
        yield return new WaitForSeconds(respawnDelay);
        // player.rigidbody2D.gravityScale = gravityStore;
        player.transform.position = currentCheckpoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        Instantiate(respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
    }
}
