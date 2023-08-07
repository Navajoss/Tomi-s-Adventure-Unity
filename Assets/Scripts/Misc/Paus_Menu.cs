using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Paus_Menu : MonoBehaviour
{

    #region pause
    public int pauseActive;
    public GameObject loadingScreen;
    public GameObject pause;
    public Slider slider;
    
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
        timeToChange -= Time.deltaTime;

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

        if (timeToChange <= 0)
        {
            currentSprite++;
        }

        if (currentSprite >= 2)
        {
            currentSprite = 0;
        }

        

        #endregion

    }
    #region pause
    public void Reload()
    {
        StartCoroutine(ReloadScene());
    }

    public void Menu()
    {
        StartCoroutine(LoadMenu());
    }

    IEnumerator ReloadScene()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }

    IEnumerator LoadMenu()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Garden");

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }
    #endregion
}
