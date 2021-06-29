using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    PauseMenu pauseMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene("Level 0.1");
    }

    private void Awake()
    {
        pauseMenu = GameObject.FindGameObjectWithTag("PauseMenu").GetComponent<PauseMenu>();
        Debug.Log(pauseMenu.name);
    }

    /*public static void CallOptions()
    {
        SceneManager.LoadScene("OptionsMenu");
    }*/

    public void ResumeTime()
    {
        Time.timeScale = 1f;
        if(pauseMenu != null)
        {
            pauseMenu.OptionsEnabled = false;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
