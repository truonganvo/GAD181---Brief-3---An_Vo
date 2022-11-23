using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseHealth : MonoBehaviour
{
    [SerializeField] HealthImpact addHealth;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            addHealth.Health += 5;
            Destroy(gameObject);
        }
    }
}
