﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public GameObject MF;
    public GameObject MC;

    public void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            TakeDamage(19);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Healing(20);
        }

        if (currentHealth <= 0)
        {
            Debug.Log("misson failed");
            MF.gameObject.SetActive(true);
        }

        /*if (currentHealth <= 0)
        {
            Debug.Log("mission complete");
            MC.gameObject.SetActive(true);
        }*/
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void Healing(int heal)
    {
        currentHealth += heal;

        healthBar.SetHealth(currentHealth);

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
