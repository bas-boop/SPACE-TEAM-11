﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Test Simon");
    }
    
    public static void CallOptions()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void ResumeTime()
    {
        Time.timeScale = 1f;
        GetComponent<PauseMenu>().OptionsEnabled = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
