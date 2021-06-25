using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleBuildOff : MonoBehaviour
{
    private BuildManger Buildstuff;
    public bool codeIsOn = true;

    private void Start()
    {
        Buildstuff = GetComponent<BuildManger>();    
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Debug.Log("hhjhfdh");
            Buildstuff.enabled = false;
            codeIsOn = false;
        }
    }
}
