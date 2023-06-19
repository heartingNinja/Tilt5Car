using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] 
    float speed = 2.0f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    public void MoveCube(InputAction.CallbackContext context)
    {
        Vector2 movement = context.ReadValue<Vector2>();
        rb.velocity = new Vector3(movement.x * speed, rb.velocity.y, movement.y * speed);
    }
}
