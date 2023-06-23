using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigid;

    private PlayerHealth _player;
    void Start()
    {
        rigid.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider other)
    {
        _player.healthcount--;
        
        Destroy(gameObject);
    }
}
