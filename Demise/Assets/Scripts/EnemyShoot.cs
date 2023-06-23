using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform shoot;
    public GameObject bullet; 
    private Animator animator;
    public Collider2D player;

    public void Start()
    {
        shoot.Rotate(0,180,0); 
        player = GameObject.Find("Player").GetComponent<Collider2D>();
        //animator = GameObject.Find("AkPixelIdle").GetComponent<Animator>();
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
            //animator.Play("Ak Pixel_Clip");
            Instantiate(bullet, shoot.position, shoot.rotation);
            yield return new WaitForSeconds(1);
        }
        
    }
    

}
