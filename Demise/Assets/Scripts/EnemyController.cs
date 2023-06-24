using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    private GameObject enemy;
    [SerializeField] public int enemyHealth = 2;
    [SerializeField] private Animator enemyAnim;
    [SerializeField] private AudioSource hitSound;
    public static EnemyController Instance { get; set; }
    public void Update()
    {
        
    }

    public void EnemyHit()
    {
        enemyHealth--;
        hitSound.Play();
        if (enemyHealth <= 0)
        {
            StartCoroutine(EnemyDead());
        }
    }

    IEnumerator EnemyDead()
    {
        if (enemyHealth <= 0)
        {
            
            enemyAnim.Play("Death");
            yield return new WaitForSeconds(1);
            Destroy(gameObject);
        }
    }
    
    
}
