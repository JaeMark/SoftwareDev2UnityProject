using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParticleManager : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public bool enableParticle = false;

    // Start is called before the first frame update
    void Start()
    {
        if (particleSystem == null)
        {
            particleSystem = GameObject.Find("BoostParticle").GetComponent<ParticleSystem>();
        }
        // Last check in case it couldn't find anything. 
        if (particleSystem == null)
        { 
            Debug.LogWarning("No Particle Systems Found on " + this.gameObject.name);
        }
    }

    // Play the particle system. 
    public void Play()
    {
        particleSystem.Play();
    }

    // Stop the particle system. 
    public void Stop()
    {
        particleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(enableParticle)
        {
            Play();
        }
        else
        {
            Stop();
        }
    }
}
