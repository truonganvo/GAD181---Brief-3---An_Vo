using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] float bulletDamage = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            enemy.health -= bulletDamage;
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("BiggerEnemy"))
        {
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            enemy.health -= bulletDamage;
            Destroy(gameObject);
        }
    }
}
