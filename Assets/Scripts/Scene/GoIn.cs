using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoIn : MonoBehaviour
{
    public float timeleft = 14f;
    void Update()
    {
        timeleft -= Time.deltaTime;
        if(timeleft <= 0f)
        {
            SceneManager.LoadScene("In");
        }
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            SceneManager.LoadScene("In");
        }
    }
    //
}
