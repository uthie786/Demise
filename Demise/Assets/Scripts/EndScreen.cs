using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private GameObject endScreen;
    [SerializeField] private AudioSource endSound;
    [SerializeField] private AudioSource winSound;
    [SerializeField] private Collider2D player;
    [SerializeField] public Text endScreenText;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ENDSCREEN");
        if (other == player)
        {
           // Debug.Log("ENDSCREEN");
           endScreenText.text = "Level Completed";
            Destroy(GameObject.Find("Player"));
            endSound.Play();
            winSound.Play();
            endScreen.SetActive(true);
        }
    }
}
