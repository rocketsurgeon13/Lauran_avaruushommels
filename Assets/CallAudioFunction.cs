using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CallAudioFunction : MonoBehaviour
{
    public AudioFW other;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            other.RandomSoundness();

        }
    }
    void Update()
    {
        
    }
}
