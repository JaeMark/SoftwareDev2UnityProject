using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public Slider healthBar;
    public TMP_Text score;


    // Start is called before the first frame update
    void Start()
    {
        // set initial score to 0
        score.text = 0.ToString();

        healthBar.maxValue = 100;
        healthBar.value = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
