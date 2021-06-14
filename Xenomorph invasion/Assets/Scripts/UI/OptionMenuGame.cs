using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionMenuGame : MonoBehaviour
{
    public void BackToGame()
    {
        SceneManager.LoadScene("Test Simon");
    }
}
