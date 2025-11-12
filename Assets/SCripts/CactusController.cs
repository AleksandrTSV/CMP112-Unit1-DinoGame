using UnityEngine;
using System.Collections;
using TMPro;

public class CactusController : MonoBehaviour
{
    public float speed = -1.5f;
    private float timer;
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
        timer += Time.deltaTime;

        Vector3 movement = new Vector3(0.0f, 0.0f, movementZ);
        rb.AddForce(0, 0, speed * Time.fixedDeltaTime, ForceMode.VelocityChange);

        if (transform.position.z < -25f)
        {
            Destroy(gameObject);
        }

        if (timer > 3f)
        {
            speed += -0.05f;
        }
    }
}
