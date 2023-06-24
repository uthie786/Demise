using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AmmoClipController : MonoBehaviour
{
    private PlayShoot _playShoot;
    [SerializeField] private AudioSource reloadSound;
    private void Start()
    {
        _playShoot = GameObject.Find("BulletExitPlayer").GetComponent<PlayShoot>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            reloadSound.Play();
            Destroy(gameObject);
            _playShoot.Reload();
        }
        
    }
}
