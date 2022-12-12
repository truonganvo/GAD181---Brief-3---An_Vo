using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public float fireForce;

    public int maxAmmo = 20;
    public int currentAmmo;
    public float reloadTime = 1f;
    public Image ammoBar;


    public TextMeshProUGUI ammoCount;
    public GameObject warning1;

    private void Start()
    {
        currentAmmo = maxAmmo;
    }

    private void Update()
    {
        ammoCount.text = currentAmmo.ToString("0");
        if (currentAmmo >= maxAmmo)
        {
            currentAmmo = maxAmmo;
        }

        if (Input.GetKeyDown(KeyCode.Keypad5) && currentAmmo > 0)
        {
            Fire();
        }

        if (currentAmmo >= 60)
        {
            ammoBar.color = Color.green;
        }
        if (currentAmmo <= 40)
        {
            ammoBar.color = Color.yellow;
        }
        if (currentAmmo <= 20)
        {
            ammoBar.color = Color.red;
            warning1.SetActive(true);
        }
        else
        {
            warning1.SetActive(false);
        }

        if (currentAmmo == 0)
        {
            ammoBar.color = Color.gray;
        }

    }

    public void Fire()
    {
        GameObject projectile = Instantiate(bullet, firePoint.position, firePoint.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        currentAmmo--;
    }
}
