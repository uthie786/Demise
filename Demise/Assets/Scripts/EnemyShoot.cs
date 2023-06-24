using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform shoot;
    public GameObject bullet; 
    [SerializeField] Animator animator;
    public Collider2D player;
    [SerializeField] private AudioSource shootAudio;

    public void Start()
    {
        shoot.Rotate(0,180,0); 
        player = GameObject.Find("Player").GetComponent<Collider2D>();
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == player)
        {
            StartCoroutine(EnemyShootTime());
        }
    }

    IEnumerator EnemyShootTime()
    {
        for (int i = 1; i < 100; i++)
        {
            
            Instantiate(bullet, shoot.position, shoot.rotation);
            shootAudio.Play();
            animator.Play("AkPixel_Clip");
            yield return new WaitForSeconds(1);
            animator.Play("New State");
        }
        
    }
    

}
