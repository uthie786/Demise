using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AmmoClipController : MonoBehaviour
{
    private PlayShoot _playShoot;
    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        _playShoot.currentAmmo = 7;
    }
}
