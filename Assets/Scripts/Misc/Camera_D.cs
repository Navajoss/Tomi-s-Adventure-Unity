using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Camera_D : MonoBehaviour
{

    public GameObject Camera_360;
    public GameObject Camera_;

    
    private void OnTriggerEnter(Collider other)
    {
        PlayerMovementAdvanced player = other.GetComponent<PlayerMovementAdvanced>();
        if (player != null)
        {
            Camera_360.gameObject.SetActive(false);
            Camera_.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerMovementAdvanced player = other.GetComponent<PlayerMovementAdvanced>();
        if (player != null)
        {

            Camera_360.gameObject.SetActive(true);
            Camera_.gameObject.SetActive(false);
        }
    }
}
