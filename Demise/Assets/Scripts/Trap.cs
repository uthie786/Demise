using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trap : MonoBehaviour
{
    private PlayerHealth ph;
   

    private AudioSource trapSound;
    // Start is called before the first frame update
    void Start()
    {
        ph = GameObject.Find("Player").GetComponent<PlayerHealth>();
        trapSound = GameObject.Find("Deathsound").GetComponent<AudioSource>();
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
           
            trapSound.Play();
            ph.healthcount = 0;
        }
        
       
    }
}
