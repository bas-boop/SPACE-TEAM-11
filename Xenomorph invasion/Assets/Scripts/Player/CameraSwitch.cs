using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;

    void Update()
    {
        if (Input.GetButtonDown("1Key"))
        {
            Cam1.SetActive(true);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
        }
        if (Input.GetButtonDown("2Key"))
        {
            Cam1.SetActive(false);
            Cam2.SetActive(true);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
        }
        if (Input.GetButtonDown("3Key"))
        {
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(true);
            Cam4.SetActive(false);
        }
        if (Input.GetButtonDown("4Key"))
        {
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(true);
        }
    }
}
