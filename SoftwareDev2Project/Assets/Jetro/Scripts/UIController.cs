using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public Slider healthBar;
    public TMP_Text score;

    private int playerScore;

    private Health playerHealth;
    private GameMode gameMode;

    // Start is called before the first frame update
    void Start()
    {
        // get player health component
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();

        healthBar.maxValue = playerHealth.maxHealth;
        healthBar.value = playerHealth.currentHealth;

        playerHealth.OnHealthChanged += UpdateHealthBar;

        // set initial score to 0
        score.text = 0.ToString();

        gameMode.OnScoreChanged += UpdateScore;
    }

    void UpdateHealthBar(int health)
    {
        healthBar.value = health;
    }

    void UpdateScore(int score)
    {
        playerScore = score;
        score.text = playerScore.ToString();
    }
}
