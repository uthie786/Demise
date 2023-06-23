using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    private GameObject enemy;
    [SerializeField] public int enemyHealth = 2;

    public static EnemyController Instance { get; set; }
    public void Update()
    {
        
    }

    public void EnemyHit()
    {
        enemyHealth--;
        if (enemyHealth <= 0)
        {
            EnemyDead();
        }
    }

    public void EnemyDead()
    {
        if (enemyHealth <= 0)
        {
            Destroy(enemy);
        }
    }
    
    
}
