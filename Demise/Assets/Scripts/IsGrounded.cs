using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    public bool groundCheck;

    public static IsGrounded Instance { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        groundCheck = true;
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        groundCheck = true;
    }

    
}
