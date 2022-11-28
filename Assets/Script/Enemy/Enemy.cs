using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 20;
    private Transform player;
    [SerializeField] float speed;

    public float timerStart = 0;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player1").transform;
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        if(health <= 0)
        {
            Die();
        }

        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player1"))
        {
            Die();
        }
    }
}
