using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetBool("isBoosting", true);
        } 
        else if (Input.GetButtonUp("Jump"))
        {
            anim.SetBool("isBoosting", false);
        }
    }
}
