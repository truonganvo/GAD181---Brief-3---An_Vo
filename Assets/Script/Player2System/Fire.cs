using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] Weapon weapon;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            weapon.Fire();
        }
    }
}
