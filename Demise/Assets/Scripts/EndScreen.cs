using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private GameObject endScreen;
    [SerializeField] private AudioSource endSound;
    [SerializeField] private AudioSource winSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            Destroy(other);
            endSound.Play();
            winSound.Play();
            endScreen.SetActive(true);
        }
    }
}
