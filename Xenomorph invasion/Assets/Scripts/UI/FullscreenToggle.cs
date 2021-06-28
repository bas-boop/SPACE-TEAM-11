using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenToggle : MonoBehaviour
{
    public void Fullscreenon(bool Fullon)
    {
        Screen.fullScreen = Fullon;
        Debug.Log("im uhh somethign on?");
    }
    public void Fullscreenoff(bool Fulloff)
    {
        Screen.fullScreen = !Fulloff;
        Debug.Log("im uhh somethign off?");
    }
}