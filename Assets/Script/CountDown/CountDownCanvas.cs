using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownCanvas : MonoBehaviour
{
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;

    public float timerValue = 20f;

    void Update()
    {
        if(timerValue > 0)
        {
            timerValue -= Time.deltaTime;
        }
        else
        {
            timerValue = 0;
            player1.SetActive(false);
            player2.SetActive(false);
        }
    }
}
