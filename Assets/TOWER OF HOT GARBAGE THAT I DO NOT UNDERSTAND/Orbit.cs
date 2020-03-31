using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject Center;
    public float Speed;
    void Start()
    {
        
    }

    void OrbitAround()
    {
        transform.RotateAround(Center.transform.position, Vector3.up, Speed * Time.deltaTime);

    }
    void Update()
    {
        OrbitAround();
    }

}
