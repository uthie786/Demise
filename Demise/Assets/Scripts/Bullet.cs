using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigid;
    private Collision2D playerPerson;

    private EnemyController _enemy;
    void Start()
    {
        _enemy = GameObject.Find("Enemy").GetComponent<EnemyController>();
        rigid.velocity = transform.right * speed;
        playerPerson = GameObject.Find("Enemy").GetComponent<Collision2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _enemy.EnemyHit();
        Debug.Log(_enemy.enemyHealth);
        
        Destroy(gameObject);
    }
}
