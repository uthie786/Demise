using System;
using System.Collections;
using System.Collections.Generic;
using Unity.UI;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int healthcount = 3;
    private bool isAlive;
    [SerializeField] public GameObject[] hearts;
    [SerializeField] private Animator playerAnim;
    [SerializeField] private AudioSource hitSound;
    [SerializeField] private AudioSource endSound;
    [SerializeField] private GameObject endScreen;
    private Image h1;
    private Image h2;
    private Image h3;
    
    public static PlayerHealth Instance { get; set; }
    void Start()
    {
        h1 = hearts[0].GetComponent<Image>();
        h2 = hearts[1].GetComponent<Image>();
        h3 = hearts[2].GetComponent<Image>();
        endScreen.SetActive(false);
    }

    private void Update()
    {
        StartCoroutine(PlayerDamaged());
    }

    public void PlayerHit()
    {
        hitSound.Play();
        healthcount--;
        Debug.Log(healthcount);
    }
    public IEnumerator PlayerDamaged()
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
            playerAnim.Play("Death");
            yield return new WaitForSeconds(1);
            endSound.Play();
            endScreen.SetActive(true);
            Destroy(gameObject);
        }
    }
    
}
