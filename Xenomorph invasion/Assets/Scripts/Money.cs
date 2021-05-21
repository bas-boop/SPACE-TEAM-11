using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public static int value;
    public int startvalue = 0;

    public GameObject mc;

    public void Start()
    {
        value = startvalue;
        mc = GameObject.Find("money_counter");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Increase(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Increase(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Increase(5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Increase(10);
        }

        if (Input.GetKeyDown(KeyCode.F1))
        {
            Decrease(1);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Decrease(2);
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            Decrease(5);
        }
        if (Input.GetKeyDown(KeyCode.F10))
        {
            Decrease(10);
        }

        mc.GetComponent<TMPro.TextMeshProUGUI>().text = "Money: " + value;
    }

    public void Increase(int increase)
    {
        value += increase;
    }
    public void Decrease(int Decrease)
    {
        value -= Decrease;
    }
}
