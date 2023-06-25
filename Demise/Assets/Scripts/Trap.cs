using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private PlayerHealth ph;
    // Start is called before the first frame update
    void Start()
    {
        ph = GameObject.Find("Player").GetComponent<PlayerHealth>();

    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        ph.healthcount = 0;
       
    }
}
