using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthImpact : MonoBehaviour
{
    public int Health, maxHealth;
    public TextMeshProUGUI health;
    public static event Action onPlayerDeath;
    public Image healthBar;

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
        if(Health <= 30)
        {
            healthBar.color = Color.red;
        }

        if(Health <= 0)
        {
            EmptyHealth();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Health -= 10;
            Vector2 difference = transform.position - collision.transform.position;
            transform.position = new Vector2(transform.position.x + difference.x, transform.position.y + difference.y);
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
