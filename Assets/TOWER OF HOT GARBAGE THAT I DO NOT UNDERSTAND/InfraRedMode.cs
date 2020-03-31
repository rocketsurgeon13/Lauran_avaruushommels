using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfraRedMode : MonoBehaviour
{
    public GameObject InfraRed;
    public GameObject NormalScreen, Planet1, Planet2, Planet3, StartPoint;
    void Start()
    {

        //InfraRed.SetActive(false);
        //  NormalScreen.SetActive(true);
    }

    // Update is called once per frame

    void Update()
    {

        if (Input.GetKey(KeyCode.F))
        {
            InfraRed.SetActive(true);
            NormalScreen.SetActive(false);
            Planet1.SetActive(false);
            Planet2.SetActive(false);

            Planet3.SetActive(true);
            StartPoint.SetActive(true);

            print("if u can see this my code works properly");
        } else
        {
            InfraRed.SetActive(false);
            NormalScreen.SetActive(true);
            Planet1.SetActive(true);
            Planet2.SetActive(true);
            Planet3.SetActive(false);
            StartPoint.SetActive(false);


        }


    }
}