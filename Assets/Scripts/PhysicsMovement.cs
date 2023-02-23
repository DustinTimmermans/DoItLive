using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsMovement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private float speed = 10;

    private Vector2 _movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(new Vector3(_movement.x, 0, _movement.y) * speed * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit the ground!");
    }

    void OnMove(InputValue value)
    {
        // Move the player
        _movement = value.Get<Vector2>();
    }

    void OnJump(InputValue value)
    {
        rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
    }
}
