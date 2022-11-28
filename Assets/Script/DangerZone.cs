using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    [SerializeField] HealthImpact lostHealth;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ammo"))
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Player1"))
        {
            lostHealth.Health -= 5;
        }
    }
}
