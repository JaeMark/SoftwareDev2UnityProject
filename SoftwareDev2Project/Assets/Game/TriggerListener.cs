using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerListener : MonoBehaviour
{
    public ColorManager colorManager;
    public ScoreManager scoreManager;

    public void Start()
    {
        colorManager = GetComponent<ColorManager>();
        scoreManager = GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (colorManager != null)
        {
            colorManager.RandomizeColor();
        }
        if(scoreManager != null)
        {
            GameObject owner = collision.gameObject;
            scoreManager.ScoreEvent(owner);
        }
    }
}
