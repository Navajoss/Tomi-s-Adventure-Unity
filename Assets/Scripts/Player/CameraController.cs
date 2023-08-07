using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController player;
    public float mouseSens = 500f;
    private float yRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        yRotation += mouseY;
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(yRotation, 0, 0), 1f);
        yRotation = Mathf.Clamp(yRotation, -90, 90);

        player.transform.Rotate(Vector3.up * mouseX);


    }

    public void OnDestroy()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
