using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public bool autoPilot;
    Vector3 spawnPosition;

    void Update()
    {
        if(autoPilot)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed );

            if(transform.position.z<0)
            {
                transform.position = spawnPosition;
            }
        }
        else
        {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = transform.position;
    }

}
