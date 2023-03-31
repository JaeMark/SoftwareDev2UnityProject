using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Vector2 movePath;
    public Transform followTarget;
    public bool activatedFollow = true;
    public float moveSpeed = 2.0f;

    public int damageAmount = 10; // amount of damage the enemy does to the player

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (activatedFollow && followTarget)
        {
            Vector2 direction = followTarget.position - transform.position;
            direction.Normalize();
            Vector3 movePath = new Vector3(direction.x, direction.y, 0) * moveSpeed * Time.deltaTime;
            transform.position += movePath;

            if (direction.x < 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            /*
            Vector2 path = followTarget.position - transform.position;
            Debug.DrawRay(transform.position, path, Color.yellow); // for debugging; 

            Vector2 movePath = Vector2.Lerp(transform.position, followTarget.position, speed);
            transform.position = new Vector2(movePath.x, movePath.y);

         
            */
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Health otherHealth = other.GetComponent<Health>();
        if (otherHealth != null) 
        {
           otherHealth.TakeDamage(damageAmount); 
        }
    }
}
