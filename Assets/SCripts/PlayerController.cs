using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce = 150f;
    InputSystem_Actions inputActions;

    private void Awake()
    {
        inputActions = new InputSystem_Actions();
        
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Platform")) 
        {
            inputActions.Player.Jump.performed += _ => OnJump();
        }
    }

    void OnJump()
    {
        

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 0.1f)) 
        {
            rb.AddForce(0, jumpForce * Time.fixedDeltaTime, 0, ForceMode.VelocityChange);
            Debug.Log("You Jumped");
        }
        
    }
}
