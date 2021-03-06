﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Confirmation for working code.");
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
        //Keep the player in bounds and from falling off the edge.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right *horizontalInput * Time.deltaTime * speed);
        
    }
}
