using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenToggle : MonoBehaviour
{
    public void Fullscreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
        Debug.Log("ooga");
    }
}