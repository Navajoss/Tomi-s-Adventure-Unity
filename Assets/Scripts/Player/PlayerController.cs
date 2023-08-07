using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (controller.isGrounded)
        {
            // Get input for movement direction
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            // Calculate movement direction based on input and player orientation
            moveDirection = new Vector3(moveHorizontal, 0.0f, moveVertical);
            moveDirection = transform.TransformDirection(moveDirection) * speed;
            

            // Jumping
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);
    }
}
