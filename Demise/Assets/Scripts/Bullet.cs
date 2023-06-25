using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigid;
    private Collision2D playerPerson;
    
    public void FixedUpdate()
    {
        rigid.velocity = transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Enemy")
        {
            other.transform.GetComponent<EnemyController>().EnemyHit();
            //_enemy.EnemyHit();
        }
        Destroy(gameObject);
        
        
    }
}
