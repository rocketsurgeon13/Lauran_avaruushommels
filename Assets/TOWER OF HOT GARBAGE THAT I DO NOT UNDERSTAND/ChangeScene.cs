using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string SceneName;
   
    void Start()
    {

    }

  /*  private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Camera)
        {
            SceneManager.LoadScene(SceneName);//(where you want to teleport)
        }
      
    }*/
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightControl))
        {
            SceneManager.LoadScene(SceneName);//(where you want to teleport)
        }
    }
}
