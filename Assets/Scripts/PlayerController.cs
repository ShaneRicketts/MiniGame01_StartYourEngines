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

    void Update()
    {
        //Axis setup
        forwardInput = Input.GetAxis("Vertical" + inputID);
        horizontalInput = Input.GetAxis("Horizontal" + inputID);

        //Moves the Car forward based on vertical input
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);

        //Rotates the Car based on horizontal input
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        if (switchKey != KeyCode.None)
        {
            if (Input.GetKeyDown(switchKey))
            {
                mainCamera.enabled = !mainCamera.enabled;
                hoodCamera.enabled = !hoodCamera.enabled;
            }
        }
    }
}
