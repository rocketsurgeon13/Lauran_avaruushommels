using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCheckpoint : MonoBehaviour
{
    public GameObject Checkpoint;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider plyr)
    {
        if(plyr.gameObject.tag== "Player")
        {
            Destroy(Checkpoint);

        }
    }
    void Update()
    {
        
    }
}
