using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleBuildOff : MonoBehaviour
{
    private Node nodeDing;
    private BuildManger Buildstuff;
    public bool codeIsOn = true;

    private void Start()
    {
        Buildstuff = GetComponent<BuildManger>();
        nodeDing = GameObject.Find("Node").GetComponent<Node>();
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Buildstuff.enabled = false;
            nodeDing.enabled = false;
            codeIsOn = false;
        }
    }

    public bool CodeStaatAan()
    {
        return codeIsOn;
    }
}
