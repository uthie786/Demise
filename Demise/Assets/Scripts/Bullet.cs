using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigid;

    private EnemyController _enemy;
    void Start()
    {
        rigid.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider other)
    {
        _enemy.enemyHealth--;
        
        Destroy(gameObject);
    }
}
