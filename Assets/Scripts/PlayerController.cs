using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed;
    public float forwardInput;
    public float horizontalInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public string inputID;
    public AudioClip carNoise;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = carNoise;
    }

    void Update()
    {
        Movement();

        SwitchCams();

        if (carNoise != null)
        {
            PlaySFX();
        }
    }

    void Movement()
    {
        //Axis setup
        forwardInput = Input.GetAxis("Vertical" + inputID);
        horizontalInput = Input.GetAxis("Horizontal" + inputID);

        //Moves the Car forward based on vertical input
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);

        //Rotates the Car based on horizontal input
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
    }

    void SwitchCams()
    {
        //switch between cameras
        if (switchKey != KeyCode.None)
        {
            if (Input.GetKeyDown(switchKey))
            {
                mainCamera.enabled = !mainCamera.enabled;
                hoodCamera.enabled = !hoodCamera.enabled;
            }
        }
    }

    void PlaySFX()
    {
        //Plays car noise when moving
        if (forwardInput > 0.01f || horizontalInput >= 0.01f || forwardInput <= -0.01f || horizontalInput <= -0.01f)
        {
            GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}
