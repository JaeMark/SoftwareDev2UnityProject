using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionListener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionExit2D(Collision2D col)
    {
        Debug.Log(this.gameObject.name + " OnCollisionExit2D event called from collision with " + col.otherCollider.gameObject.name);
    }

    void OnCollisionStay2D(Collision2D col)
    {
        Debug.Log(this.gameObject.name + " OnCollisionStay2D event called from collision with " + col.otherCollider.gameObject.name);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collided with: " + col.otherCollider.gameObject.name) ;
        Debug.Log(this.gameObject.name + " OnCollisionEnter2D event called from collision with " + col.otherCollider.gameObject.name);
    }
}

