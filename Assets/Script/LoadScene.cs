using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public GameObject GameOver;
    [SerializeField] TimerScore stopscoring;
    [SerializeField] AudioSource musicTheme;

    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnEnable()
    {
        HealthImpact.onPlayerDeath += EnableGameOverMenu;
    }

    private void OnDisable()
    {
        HealthImpact.onPlayerDeath -= EnableGameOverMenu;
    }

    public void EnableGameOverMenu()
    {
        stopscoring.StopTimer();
        GameOver.SetActive(true);
    }
}
