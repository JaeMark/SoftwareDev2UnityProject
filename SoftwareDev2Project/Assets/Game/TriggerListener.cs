using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerListener : MonoBehaviour
{
    public ColorManager manager;

    public void Start()
    {
        manager = GetComponent<ColorManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (manager != null)
        {
            manager.RandomizeColor();
        }
    }
}
