using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class Particle : MonoBehaviour
{
    public ParticleSystem ParticleSystem;

    void FixedUpdate()
    {
        ParticleSystem.Play();
    }

}