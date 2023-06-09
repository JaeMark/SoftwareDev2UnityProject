using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{
    public static GameMode instance;
    public event Action<int> OnScoreChanged;

    public UIController uiController;

    private int playerScore = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AddScore(int score)
    {
        playerScore += score;
        Debug.Log("Player score: " + playerScore);

        OnScoreChanged?.Invoke(playerScore);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        uiController.ShowRestartButton();
    }
}
