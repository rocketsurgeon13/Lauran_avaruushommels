using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
 
    public float maxTime = 5f;
    float timeleft;
    public GameObject timesUpText;
    public float increaseTime = 1f;
    public Image image;
    

    void Start()
    {
        timesUpText.SetActive(false);
       
        timeleft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeleft> 0)
        {
            timeleft -= Time.deltaTime;
            image.fillAmount = timeleft / maxTime;
        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale=0;
        }

       

     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="CheckPoint")
            timeleft += increaseTime;
        image.fillAmount = timeleft / maxTime;
    }
}
