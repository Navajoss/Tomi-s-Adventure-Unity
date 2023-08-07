using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToTubes : MonoBehaviour
{
    public float timeleft = 14f;
    void Update()
    {
        timeleft -= Time.deltaTime;
        if(timeleft <= 0f)
        {
            SceneManager.LoadScene("Tubes");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Tubes");
        }
    }
    //
}
