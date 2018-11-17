﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController2D : MonoBehaviour {

    public float speed = 5.0f;
    private Rigidbody2D rigidbody2D;
    bool playerWalking;
    Animator animator;
        
    SpriteRenderer spriterender;


	// Use this for initialization
	void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rigidbody2D.velocity = new Vector2(x, y) * speed;
        rigidbody2D.angularVelocity = 0.0f;

        //sprite rotation 
        spriterender = GetComponent<SpriteRenderer>();
        if (x < 0)
        {
            spriterender.flipX = true;

        }
        else if (x > 0)
        {
            spriterender.flipX = false;
        }
                


        //setting walking state for anim purposes

        if ((x != 0) || (y != 0))
        {
            playerWalking = true;
            animator.SetBool("playerWalking", playerWalking);
        }
        else
        {

            //Debug.Log(playerWalking);
            playerWalking = false;
            animator.SetBool("playerWalking", playerWalking);
        }
	}
}
