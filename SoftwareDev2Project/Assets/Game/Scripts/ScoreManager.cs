using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float boundaryMinX, boundaryMaxX, boundaryMinY, boundaryMaxY;
    public int score = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ScoreEvent(GameObject other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameMode.instance.AddScore(score);
            // move to a random location
            float randX = Random.Range(boundaryMinX, boundaryMaxX);
            float randY = Random.Range(boundaryMinY, boundaryMaxY);
            transform.position = new Vector3(randX, randY, transform.position.z);
        }
    }
}
