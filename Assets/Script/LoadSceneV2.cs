using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneV2 : MonoBehaviour
{
    public void BackToUI()
    {
        SceneManager.LoadScene("UI");
    }
}
