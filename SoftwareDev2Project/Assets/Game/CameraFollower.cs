using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform followTarget;
    public bool activatedFollow = true;
    public float zOffset = 10f;

    public float lerpSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (activatedFollow)
        {
            Vector2 path = followTarget.position - transform.position;
            Debug.DrawRay(transform.position, path, Color.yellow); // for debugging; 

            Vector2 lerpPath = Vector2.Lerp(transform.position, followTarget.position, Time.deltaTime * lerpSpeed);
            transform.position = new Vector3(lerpPath.x, lerpPath.y, zOffset);
        }
    }
}
