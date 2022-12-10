using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class PlayTheVideo : MonoBehaviour
{
    public GameObject videoPlayer;
    public GameObject thankYou;

    // The amount of time to wait before enabling the object
    public float delay = 5.0f;

    // The button that you want to press to start the delay
    public Button button;

    // A flag to track whether the object has been enabled
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
    private bool enabled = false;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

    private void Start()
    {
        // Add a listener to the button's onClick event
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        // Start the delay
        StartCoroutine(Delay());
    }

    private IEnumerator Delay()
    {
        // Wait for the specified amount of time
        yield return new WaitForSeconds(delay);

        // Enable the target object
        thankYou.SetActive(true);
    }

    public void PlayVideo()
    {
        videoPlayer.SetActive(true);
    }
}
