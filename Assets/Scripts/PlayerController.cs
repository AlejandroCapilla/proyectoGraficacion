using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject cube;
    public float jumpImpulse = 1.0f;
    public float jumpForce = 1.0f;
    private bool canJump  = true;
    private Rigidbody Physics;
    // Start is called before the first frame update
    void Start()
    {
        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            canJump = false;
            Physics.AddForce(new Vector3(0,jumpImpulse,0), ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Physics.AddForce(new Vector3(0,jumpForce * Time.deltaTime,0), ForceMode.Force);
            canJump = true;
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            cube.transform.Rotate(0,0,36);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            cube.transform.Rotate(0,0,-36);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "plataform")
        {
            canJump = true;
        }
    }
}
