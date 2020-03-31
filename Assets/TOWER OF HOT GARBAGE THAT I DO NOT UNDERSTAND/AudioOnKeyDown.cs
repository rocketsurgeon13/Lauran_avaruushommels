using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnKeyDown : MonoBehaviour
{

    public AudioClip soundtoplay;
    public AudioClip soundtoplay2;
    public AudioClip soundtoplay3;
    public float Volume;
    public float Volume2;
    public float Volume3;
    AudioSource playaudio;
    void Start()
    {
        playaudio = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        //Press Right Mouse Button to accelerate
        if (Input.GetKey(KeyCode.W))
        {
            playaudio.PlayOneShot(soundtoplay, Volume);
        }
       
        if (Input.GetKey(KeyCode.A))
        {
            playaudio.PlayOneShot(soundtoplay2, Volume2);
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            playaudio.PlayOneShot(soundtoplay3, Volume3); 
        }
    }
}

