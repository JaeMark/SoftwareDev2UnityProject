using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;   

    void Start()
    {
        currentHealth = maxHealth; 
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log("Player has taken " + damageAmount + " damage");
        Debug.Log("Player health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die(); 
        }
    }

    void Die()
    {
        Debug.Log("Player has died.");
    }

}
