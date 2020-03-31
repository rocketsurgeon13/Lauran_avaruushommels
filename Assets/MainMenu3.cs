using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Start_Cutscene");
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("U DONE DID IT BEEEEEECH");
            Application.Quit();
        }
    }
}
