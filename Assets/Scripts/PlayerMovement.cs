using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    float horizontalMove = 0f;
    float verticalMove = 0f;

    public float runSpeed = 40f;
    public float breathTime = 5f;

    bool jumped = false;
    bool crouched = false;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        verticalMove = Input.GetAxisRaw("Vertical") * runSpeed;



        if (Input.GetButtonDown("Jump"))
        {
            jumped = true;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouched = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouched = false;
        }


    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouched, jumped);
        jumped = false;
    }

    public void OnLanding()
    {
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        /*if (col.tag == "Finish")
        {
            deathManager.Respawn();
        }
        if (col.tag == "Trap")
        {
            deathManager.Respawn();
        }
        if (col.tag == "Water")
        {
            swimming = true;
            animator.SetBool("IsSwimming", true);
            drawnTime = Time.time + breathTime;
        }*/
    }
    void OnTriggerExit2D(Collider2D col)
    {/*
        if (col.tag == "Water")
        {
            swimming = false;
            animator.SetBool("IsSwimming", false);
        }*/
    }
}
