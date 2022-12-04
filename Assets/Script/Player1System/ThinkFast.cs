using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinkFast : MonoBehaviour
{
    [SerializeField] SimpleFlash flashEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("BiggerEnemy") || collision.gameObject.CompareTag("Trap"))
        {
            flashEffect.Flash();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Trap"))
        {
            flashEffect.Flash();
        }
    }
}
