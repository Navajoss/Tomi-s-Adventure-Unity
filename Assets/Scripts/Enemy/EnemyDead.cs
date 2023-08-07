using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDead : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        EnemyStateManager enemy = other.GetComponent<EnemyStateManager>();
        if (enemy != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
