using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject pauseMenuScene;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuScene.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    void Pause()
    {
        pauseMenuScene.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void LoadOptions()
    {
        SceneManager.LoadScene("GameOptionsMenu");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
