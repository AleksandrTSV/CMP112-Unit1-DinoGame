using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce = 250f;
    InputSystem_Actions inputActions;

    private void Awake()
    {
        inputActions = new InputSystem_Actions();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Ray ray = new Ray(transform.position, -Vector3.up);
        Debug.DrawRay(transform.position, Vector3.down, Color.red);

        inputActions.Player.Jump.performed += _ => OnJump();
    }

    void OnJump()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 0.6f))
        {
            rb.AddForce(0, jumpForce * Time.fixedDeltaTime, 0, ForceMode.VelocityChange);
            
        }

    }
}
