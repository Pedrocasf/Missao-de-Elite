using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public Rigidbody rb;
    public float forceAmount = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * forceAmount * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.left * forceAmount * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(Vector3.back * forceAmount * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector3.right * forceAmount * Time.deltaTime);
        }
    }
}