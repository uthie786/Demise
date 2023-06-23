using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigid;
    private Collision2D playerPerson;

    private PlayerHealth _player;
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerHealth>();
        rigid.velocity = transform.right * speed;
        playerPerson = GameObject.Find("Player").GetComponent<Collision2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log(_player.healthcount);
            _player.PlayerHit();
        }

        Destroy(gameObject);
    }
}
