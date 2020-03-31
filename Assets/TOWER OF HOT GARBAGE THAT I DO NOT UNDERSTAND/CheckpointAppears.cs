using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointAppears : MonoBehaviour
{

    public GameObject Route;
    public GameObject HideThis;
    public GameObject Player;
    public GameObject HealthManager;
   



    void Start()
    {
        Route.SetActive(false);
        

    }

    private void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            Route.SetActive(true);
            HideThis.SetActive(false);
            HealthManager.SetActive(true);
          
        }
    }

    void Update()
    {

    }
}