using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayShoot : MonoBehaviour
{
    public Transform shoot;
    public GameObject bullet;

    public int currentAmmo = 7;
    private UIController _ui;

    public static PlayShoot Instance { get; set; }
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
            Instantiate(bullet, shoot.position, shoot.rotation);
            currentAmmo--;
        }
        
    }
}
