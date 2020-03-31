using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu2 : MonoBehaviour
{
    /* // Start is called before the first frame update
     public void PlayGame()
     {
         SceneManager.LoadScene("Main");

     }
     public void QuitGame()
     {

         Debug.Log("U DONE DID IT BEEEEEECH");
         Application.Quit();
     } */

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            SceneManager.LoadScene("Main");
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("U DONE DID IT BEEEEEECH");
            Application.Quit();
        }
    }
}
