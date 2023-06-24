using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private PlayShoot _playShoot;
    public Text ammoText;
    [SerializeField] private AudioSource gameMusic;
    public static UIController Instance { get; set; }

    public void Start()
    {
        _playShoot = GameObject.Find("BulletExitPlayer").GetComponent<PlayShoot>();
        gameMusic.Play();
    }
    
    public void SetAmmo()
    {
        int ammo;
        ammo = _playShoot.currentAmmo;
        ammoText.text = ammo.ToString();
    }
}
