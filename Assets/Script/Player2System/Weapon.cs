using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public float fireForce;

    public int maxAmmo = 20;
    private int currentAmmo;
    public float reloadTime = 1f;

    public TextMeshProUGUI ammoCount;

    private void Start()
    {
        currentAmmo = maxAmmo;
    }

    private void Update()
    {
        ammoCount.text = currentAmmo.ToString("0");

        if (Input.GetKeyDown(KeyCode.Keypad5) && currentAmmo > 0)
        {
            Fire();
        }
    }

    public void Fire()
    {
        GameObject projectile = Instantiate(bullet, firePoint.position, firePoint.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        currentAmmo--;
    }
}
