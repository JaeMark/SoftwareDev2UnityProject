using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void RandomizeColor()
    {
        sprite.color = Random.ColorHSV(0, 1f, 0.5f, 1f, 0.5f, 1f);
    }
}
