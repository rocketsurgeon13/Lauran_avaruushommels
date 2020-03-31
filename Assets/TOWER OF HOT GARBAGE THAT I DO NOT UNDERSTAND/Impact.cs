using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Impact : MonoBehaviour
{
  //public Transform Checkpoint;
    public GameObject Player;
    public AudioClip soundtoplay;
    public float Volume;
    AudioSource playaudio;
    public string SceneName;


    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        playaudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider plyr)

    {
        if (plyr.gameObject.tag == "Player")
        {
            //Player.transform.position = Checkpoint.position;
            // playaudio.PlayOneShot(soundtoplay, Volume);

            SceneManager.LoadScene(SceneName);
        }
       
    }
   
    void Update()
    {
    
    }
}
