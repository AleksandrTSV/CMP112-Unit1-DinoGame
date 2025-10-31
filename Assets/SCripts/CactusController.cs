using UnityEngine;

public class CactusController : MonoBehaviour
{
    public float speed = -3;
    private float movementZ;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementZ = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(0.0f, 0.0f, movementZ);
        rb.AddForce(0,0,speed * Time.deltaTime, ForceMode.VelocityChange);

        if (transform.position.z < -25f) 
        {
            Destroy(gameObject);
            
        }
    }
}
