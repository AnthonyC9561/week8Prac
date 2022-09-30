using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis(InputAxes.Horizontal);
        float vertical = Input.GetAxis(InputAxes.Vertical);

        rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
        transform.Translate(rb.velocity * Time.deltaTime);

        //maybe this way below so we don't need to get RigidBody component?
        // Vector3 velocity = new Vector3();

        // velocity.x = Input.GetAxis(InputAxes.Horizontal);
        // velocity.z = Input.GetAxis(InputAxes.Vertical);

        // transform.Translate(velocity * speed * Time.deltaTime);
    }
}
