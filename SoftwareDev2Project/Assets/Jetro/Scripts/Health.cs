using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public event Action<int> OnHealthChanged;

    private GameMode gameMode;

    void Start()
    {
        currentHealth = maxHealth;

        // get game mode object
        gameMode = GameObject.FindObjectOfType<GameMode>();
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log("Player has taken " + damageAmount + " damage");
        Debug.Log("Player health: " + currentHealth);

        OnHealthChanged?.Invoke(currentHealth);

        if (currentHealth <= 0)
        {
            Die(); 
        }
    }

    void Die()
    {
        gameMode.GameOver();
    }
}
