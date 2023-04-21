using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Slider healthBar;
    public TMP_Text score;
    public Button restartButton;

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

        restartButton.gameObject.SetActive(false);
        restartButton.onClick.AddListener(RestartGame);
    }

    private void UpdateHealthBar(int newHealth)
    {
        healthBar.value = newHealth;
    }

    private void UpdateScore(int newScore)
    {
        int playerScore = newScore;
        score.text = playerScore.ToString();
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void ShowRestartButton()
    {
        restartButton.gameObject.SetActive(true);
    }
}




/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Slider healthBar;
    public TMP_Text score;
    public Button restartButton;

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

        restartButton.gameObject.SetActive(false);
        restartButton.onClick.AddListener(RestartGame);

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

    void ShowRestartButton()
    {
        restartButton.gameObject.SetActive(true);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
*/



