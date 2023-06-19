using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarMovement : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public float forwardSpeed = 5f;

    private Rigidbody rb;
    public bool isMovingForward = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void StartMoving(InputAction.CallbackContext context)
    {
        
        if (context.started)
        {
            isMovingForward = true;
        }
        else if (context.canceled)
        {
            isMovingForward = false;
        }
    }

    public void RotateCar(InputAction.CallbackContext context)
    {
        Vector2 rotatoin = context.ReadValue<Vector2>();
        float rotationInput = rotatoin.x;
        transform.Rotate(0f, rotationInput * rotationSpeed * Time.deltaTime, 0f);
    }

    private void FixedUpdate()
    {
        if (isMovingForward)
        {
            rb.velocity = transform.forward * forwardSpeed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
