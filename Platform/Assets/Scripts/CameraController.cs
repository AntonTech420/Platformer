using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public PlayerController player;

    public bool isAttached;
    public bool isFollowing;

    public float xOffset;
    public float yOffset;
 
    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        isFollowing = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isFollowing)
        {
            transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, transform.position.z);
        }
        
    }
}
