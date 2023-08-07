using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToBattle : MonoBehaviour
{
    public float timeleft = 13f;
    void Update()
    {
        timeleft -= Time.deltaTime;
        if(timeleft <= 0f)
        {
            SceneManager.LoadScene("Boss");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Boss");
        }

    }
    //
}
