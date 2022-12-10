using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinCondition : MonoBehaviour
{
    // The object that you want to enable
    public GameObject targetObject;

    // The amount of time to wait before enabling the object
    public float delay = 5.0f;

    // A flag to track whether the object has been enabled
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
    private bool enabled = false;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

    private void Update()
    {
        // Check if the object has already been enabled
        if (enabled)
        {
            return;
        }

        // Decrement the delay timer
        delay -= Time.deltaTime;

        // Check if the delay timer has reached zero
        if (delay <= 0.0f)
        {
            // Enable the target object
            targetObject.SetActive(true);

            // Set the flag to indicate that the object has been enabled
            enabled = true;
        }
    }
}
