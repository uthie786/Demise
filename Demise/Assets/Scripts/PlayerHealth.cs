using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int playerHealth;
    public int healthcount = 3;
    private bool isAlive;
    [SerializeField] public GameObject[] hearts;
    
    private SpriteRenderer h1;
    private SpriteRenderer h2;
    private SpriteRenderer h3;
    void Start()
    {
        h1 = hearts[0].GetComponent<SpriteRenderer>();
        h2 = hearts[1].GetComponent<SpriteRenderer>();
        h3 = hearts[2].GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        PlayerDamaged();
    }

    public void PlayerDamaged()
    {
        if (healthcount > 0)
        {
            isAlive = true;
            
            if (healthcount == 3)
            {
                h1.enabled = true;
                h2.enabled = true;
                h3.enabled = true;
                
            }
            if (healthcount == 2)
            {
                h1.enabled = true;
                h2.enabled = true;
                h3.enabled = false;
                
            }
            if (healthcount == 1)
            {
                h1.enabled = true;
                h2.enabled = false;
                h3.enabled = false;
                
            }

        }
        else 
        {
            h1.enabled = false;
            h2.enabled = false;
            h3.enabled = false;
            Destroy(gameObject);
        }
    }
    
}
