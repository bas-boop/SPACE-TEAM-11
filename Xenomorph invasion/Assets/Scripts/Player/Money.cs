using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField]
    public int money = 0;

    [SerializeField]
    private int startingMoney = 100;

    [SerializeField]
    private Text moneyAmountText;

    private void Start()
    {
        money = startingMoney;
    }

    private void Update()
    {
        moneyAmountText.text = money + "$";
    }
}
