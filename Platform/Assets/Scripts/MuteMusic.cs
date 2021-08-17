using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuteMusic : MonoBehaviour
{
    [SerializeField]
    KeyCode MutingMusic;

    [SerializeField]
    AudioSource background;
    
    private bool isMuted;




    // Start is called before the first frame update
    void Start()
    {
        
        isMuted = false;
    }

    void Update()
    {
        if(Input.GetKey(MutingMusic)){
            Debug.Log(isMuted);
            if(isMuted)
            {
               isMuted = false;
            AudioListener.pause = false;
            }
            else 
            {
                isMuted = true;
            AudioListener.pause = true;
            }
        }
        
    }
}