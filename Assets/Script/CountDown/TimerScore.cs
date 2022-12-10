using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerScore : MonoBehaviour
{
    public float timer = 0f;
    private float timeIncrease = 1f;

    bool timerActive = false;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI HighScore;

    [SerializeField] GameObject enemyActivate;
    [SerializeField] GameObject enemyActivate1;
    [SerializeField] GameObject enemyActivate2;
    [SerializeField] GameObject objective;


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

        if(timer >= 30f)
        {
            objective.SetActive(true);
        }

        if (timer >= 55f)
        {
            enemyActivate1.SetActive(true);

        }

        if (timer >= 135f)
        {
            enemyActivate2.SetActive(true);
        }

        Win();
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

    private void Win()
    {
        if (timer >= 190f)
        {
            SceneManager.LoadScene("Ending");
        }
    }
}
