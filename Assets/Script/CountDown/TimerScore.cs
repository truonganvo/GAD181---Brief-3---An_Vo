using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScore : MonoBehaviour
{
    private float timer = 0f;
    private float timeIncrease = 1f;

    bool timerActive = false;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI HighScore;

    [SerializeField] GameObject enemyActivate;
    [SerializeField] GameObject enemyActivate1;
    [SerializeField] GameObject enemyActivate2;


    [SerializeField] Enemy increaseEnemy;
    private void Start()
    {
        timeText.text = timer.ToString("0");
    }
    private void Update()
    {
        if (!timerActive)
        {
            StartTimer();
            timeText.text = timer.ToString("0");
        }

        if(timer >= 10f)
        {
            enemyActivate.SetActive(true);
        }

        if (timer >= 100f)
        {
            enemyActivate1.SetActive(true);

        }

        if (timer >= 200f)
        {
            enemyActivate2.SetActive(true);
        }
    }

    public void StartTimer()
    {
        timer += timeIncrease * Time.deltaTime;
    }

    public void StopTimer()
    {
        timerActive = true;
        HighScore.text = timer.ToString("0");
    }


}
