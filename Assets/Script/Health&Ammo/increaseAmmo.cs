using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseAmmo : MonoBehaviour
{
    [SerializeField] Weapon addAmmo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player1"))
        {
            addAmmo.currentAmmo += 10;
            Destroy(gameObject);
        }
    }
}
