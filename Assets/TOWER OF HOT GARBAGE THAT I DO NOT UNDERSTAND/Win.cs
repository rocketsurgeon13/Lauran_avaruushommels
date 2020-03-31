using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

    
    GameObject Player;
    public AudioClip Success;
    public string EndScene;

 
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        
    }

    private void OnTriggerEnter(Collider plyr)

    {
        if (plyr.gameObject.tag == "Player")
        {

            SceneManager.LoadScene(EndScene);
            print("U SURVIVED BEEEEECH");
        }
       
    }
    void Update()
    {

    }
}
