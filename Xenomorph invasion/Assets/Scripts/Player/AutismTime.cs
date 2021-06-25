using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutismTime : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1) && (Input.GetKeyDown(KeyCode.F2)))
        {
            Time.timeScale += 1f;
        }
    }
}
