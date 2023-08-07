using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OptionsActive : MonoBehaviour
{

    #region pause
    public int pauseActive;
    public GameObject pause;


    private float timeToChange;
    private int currentSprite = 0;
    #endregion
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        #region pause
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause.SetActive(!pause.activeSelf);
            Cursor.visible = true;
        }

        if (pause.activeInHierarchy)
        {
            pauseActive = 1;
        }
        else
        {
            pauseActive = 0;
        }

        if (pause.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
                
        #endregion

    }
}