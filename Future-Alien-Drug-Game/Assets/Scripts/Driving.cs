using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driving : MonoBehaviour
{
    [Header("Moving")]
    public float speed = 1;
    public float maxSpeed = 10f;
    public float Gravity = 10f;
    public Rigidbody rb;
    public LayerMask groundLayer;

    [Header("Turning")]
    public float maxSteerAngle = 0.1f;
    public float rotationSpeed = 1;

    void Start()
    {


    }

    public void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Turn();
        rb.AddRelativeForce(Vector3.down * Gravity * 500);
    }
    public void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed * 1000);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.back * speed * 0.5f * 1000);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            speed = 0;
        }
    }

    void Turn()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float steerAngle = horizontalInput * maxSteerAngle;
        Quaternion rotation = Quaternion.Euler(0f, steerAngle, 0f);
        rb.MoveRotation(rb.rotation * rotation);
    }
}