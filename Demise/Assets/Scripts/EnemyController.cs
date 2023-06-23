using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    private GameObject enemy;
    [SerializeField] public int enemyHealth = 3;


    public void Update()
    {
        EnemyDead();
    }

    public void EnemyDead()
    {
        if (enemyHealth <= 0)
        {
            Destroy(enemy);
        }
    }
    
    
}
