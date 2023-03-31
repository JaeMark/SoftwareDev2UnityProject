using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector2 inputVector; 
    public float moveSpeed = 10f; 
    public float forceAmount = 10f;
    public float torqueAmount = 4f;

    public Rigidbody2D rigid;

    public bool boost = false;
    public float boostForceBase = 1f;
    public float boostForceMomentum = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        inputVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        boost = Input.GetButton("Jump");
        if(boost)
        {
            Vector2 normalizedInput = inputVector.normalized;
            Vector2 baseVector = new Vector2(normalizedInput.x * boostForceBase, normalizedInput.y * boostForceBase);
            Vector2 momentumVector = new Vector2(inputVector.x * boostForceMomentum, inputVector.y * boostForceMomentum);
            rigid.AddForce((baseVector + momentumVector), ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.AddForce(new Vector3(0, inputVector.y, 0) * forceAmount);
        rigid.AddTorque(-inputVector.x * torqueAmount);
    }
}
