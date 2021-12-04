using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactReaction : MonoBehaviour
{
    public bool playsOnPlayerHit;
    public AudioClip impactSound;
    private bool canMakeSound;
    private float waitTilStart = 1f;
    public float soundResetTime = 2;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = impactSound;
        InvokeRepeating("AllowSound", waitTilStart, soundResetTime);
    }

    void OnCollisionEnter(Collision other)
    {
        if (canMakeSound && impactSound != null)
        {
            if (playsOnPlayerHit)
            {
                if (other.gameObject.CompareTag("Player"))
                {
                    PlaySound();
                }
            }
            else if (!playsOnPlayerHit)
            {
                PlaySound();
            }
        }
    }

    void AllowSound()
    {
        canMakeSound = true;
    }
    void PlaySound()
    {
        GetComponent<AudioSource>().Play();
        canMakeSound = false;
    }
}
