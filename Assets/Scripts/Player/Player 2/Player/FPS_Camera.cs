using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FPS_Camera : MonoBehaviour
{
    public float Sensivility = 40;
    public Transform playerBody;
    public float xRotacion;
    public float angleLock = 50;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
       


        float mouseX = Input.GetAxis("Mouse X") * Sensivility * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Sensivility * Time.deltaTime;

        xRotacion -= mouseY;
        xRotacion = Mathf.Clamp(xRotacion, -(angleLock + 10), angleLock);

        transform.localRotation = Quaternion.Euler(xRotacion, 0, 0);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
