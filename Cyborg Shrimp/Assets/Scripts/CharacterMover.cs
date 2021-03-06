﻿using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMover : MonoBehaviour
{
   private CharacterController controller;
   public float moveSpeed = 10f, gravity = -9.8f, jumpForce = 15f;

   private Vector3 moveDirection;
   private float yDirection;

   private void Start()
   {
      controller = GetComponent<CharacterController>();
   }

   private void Update()
   {
      var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
      moveDirection.Set(moveSpeedInput,yDirection,0);

      yDirection += gravity * Time.deltaTime;

      if (controller.isGrounded  && moveDirection.y < 0)
      {
         yDirection = -1f;
      }

      if (Input.GetButtonDown("Jump"))
      {
         yDirection += jumpForce;
      }
      
      controller.Move(moveDirection * Time.deltaTime);
   }
}
