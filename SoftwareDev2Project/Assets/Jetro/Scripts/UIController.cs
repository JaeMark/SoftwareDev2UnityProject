using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public Slider healthBar;
    public TMP_Text score;

    private Health playerHealth;
    private GameMode gameMode;

    // Start is called before the first frame update
    void Start()
    {
        // get player health component
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        // set default health bar
        healthBar.maxValue = playerHealth.maxHealth;
        healthBar.value = playerHealth.currentHealth;

        // set default score to 0
        score.text = "0";
        // get game mode object
        gameMode = GameObject.FindObjectOfType<GameMode>();

        playerHealth.OnHealthChanged += UpdateHealthBar;
        gameMode.OnScoreChanged += UpdateScore;
    }

    void UpdateHealthBar(int newHealth)
    {
        healthBar.value = newHealth;
    }

    void UpdateScore(int newScore)
    {
        int playerScore = newScore;
        score.text = playerScore.ToString();
    }
}




