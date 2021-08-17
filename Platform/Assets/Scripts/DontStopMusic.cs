using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontStopMusic : MonoBehaviour
{
    private static DontStopMusic musicManagerInstance;
    void Awake() 
    {
        DontDestroyOnLoad(transform.gameObject);

        if(musicManagerInstance == null){
            musicManagerInstance = this;
        }else{
            Destroy(gameObject);
        }
    }
    
}

