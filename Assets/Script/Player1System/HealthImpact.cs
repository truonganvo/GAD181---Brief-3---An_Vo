using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthImpact : MonoBehaviour
{
    public int Health;
    public TextMeshProUGUI health;
    public static event Action onPlayerDeath; 

    private void Update()
    {
        health.text = Health.ToString("0");
        if(Health > 100)
        {
            Health = 100;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Health -= 20;
            if(Health <= 0)
            {
                EmptyHealth();
            }
        }
    }

    private void EmptyHealth()
    {
        onPlayerDeath?.Invoke();
    }
}
