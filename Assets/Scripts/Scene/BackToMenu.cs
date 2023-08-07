using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public float timeleft = 103f;
    void Update()
    {
        timeleft -= Time.deltaTime;
        if(timeleft <= 0f)
        {
            SceneManager.LoadScene("Garden");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Garden");
        }
    }
    //
}
