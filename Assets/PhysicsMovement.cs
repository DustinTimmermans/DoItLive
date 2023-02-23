using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private float force = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FixedUpdate()
    {
        if (Input.GetKey("space"))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit the ground!");
    }
}
