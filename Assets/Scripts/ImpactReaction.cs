using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactReaction : MonoBehaviour
{
    public AudioClip impactSound;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = impactSound;
    }

    void OnCollisionEnter()
    {
        GetComponent<AudioSource>().Play();
    }
}
