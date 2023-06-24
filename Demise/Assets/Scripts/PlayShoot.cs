using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayShoot : MonoBehaviour
{
    public Transform shoot;
    public GameObject bullet;
    [SerializeField] private AudioSource shootAudio;
    public int currentAmmo = 7;
    private UIController _ui;

    public static PlayShoot Instance { get; set; }

    private void Start()
    {
        _ui = GameObject.Find("GameWindow").GetComponent<UIController>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            _ui.SetAmmo();
        }
    }


    void Shoot()
    {
        if (currentAmmo > 0)
        {
            shoot.Rotate(0,0,0);
            shootAudio.Play();
            Instantiate(bullet, shoot.position, shoot.rotation);
            currentAmmo--;
        }
        
    }

    public void Reload()
    {
        currentAmmo = 7;
        _ui.SetAmmo();
    }
}
