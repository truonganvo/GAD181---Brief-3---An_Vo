using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthImpact : MonoBehaviour
{
    public int Health, maxHealth, healthThreshold = 30;

    public TextMeshProUGUI health;
    public static event Action onPlayerDeath;
    public Image healthBar;

    public AudioSource lowHealth;
    public AudioClip SFX;
    public GameObject warning;

    private void Start()
    {
        Health = maxHealth;
    }
    private void Update()
    {
        health.text = Health.ToString("0");
        if(Health >= 100)
        {
            Health = 100;
            healthBar.color = Color.green;
        }
        if(Health <= 60)
        {
            healthBar.color = Color.yellow;
        }

        if (Health <= 30)
        {
            healthBar.color = Color.red;
            warning.SetActive(true);
        }
        else
        {
            warning.SetActive(false);

        }

        //Check if the current health is below the threshold.
        if (Health <= healthThreshold && !lowHealth.isPlaying)
        {
            lowHealth.clip = SFX;
            lowHealth.Play();
        }
        else if (Health > healthThreshold && lowHealth.isPlaying)
        {
            lowHealth.Stop();
        }


        if (Health <= 0)
        {
            EmptyHealth();
            lowHealth.Stop();
            warning.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Health -= 10;
        }

        if (collision.gameObject.CompareTag("BiggerEnemy"))
        {
            Health -= 20;
        }
    }

    private void EmptyHealth()
    {
        onPlayerDeath?.Invoke();
    }
}
