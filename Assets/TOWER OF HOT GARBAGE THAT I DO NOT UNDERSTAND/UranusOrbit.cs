using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UranusOrbit : MonoBehaviour
{
    public GameObject Center;
    public float USpeed;
    void Start()
    {

    }

    void UranusOrbitAround()
    {
        transform.RotateAround(Center.transform.position, Vector3.down, USpeed * Time.deltaTime);

    }
    void Update()
    {
        UranusOrbitAround();
    }

}
