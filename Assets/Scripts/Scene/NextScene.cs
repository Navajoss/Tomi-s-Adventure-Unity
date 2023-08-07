using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerMovementAdvanced player = other.GetComponent<PlayerMovementAdvanced>();
        if (player != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
