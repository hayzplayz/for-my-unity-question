using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    public Joystick joystick;

    float horizontalMove = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {

        if (joystick.Horizontal >= .2f)
        {
            horizontalMove = runSpeed;
        } else if (joystick.Horizontal <= -.2f)
        {
            horizontalMove = -runSpeed;
        } else
        {
            horizontalMove = 0f;
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

    }

    void FixedUpdate ()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
