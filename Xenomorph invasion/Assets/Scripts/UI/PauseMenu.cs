using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public bool OptionsEnabled = false;
    public GameObject pauseMenuScene;
    //private Component buildcodething;

    /*void Start()
    {
        buildcodething = GetComponent<Component>();
    }*/

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && OptionsEnabled == false)
        {
            /*if (GamePaused)
            {
                Resume();
                OptionsMenu;
            }*/
            {
                Pause();
                //buildcodething.GetComponent<BuildManger>().enabled = (false);
            }
        }
    }

    public void Resume()
    {
        pauseMenuScene.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
        OptionsEnabled = false;
    }

    void Pause()
    {
        pauseMenuScene.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
        OptionsEnabled = true;
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
