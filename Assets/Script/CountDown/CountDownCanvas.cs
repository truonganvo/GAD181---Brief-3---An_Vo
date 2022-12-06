using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownCanvas : MonoBehaviour
{
    [SerializeField] GameObject player1and2canvas;


    public float timerValue = 20f;

    void Update()
    {
        if(timerValue > 0)
        {
            timerValue -= Time.deltaTime;
        }
        else if(timerValue == 5)
        {
            GetComponent<Alert>().enabled = false;
        }
        else
        {
            timerValue = 0;
            player1and2canvas.SetActive(false);
        }

    }
}
