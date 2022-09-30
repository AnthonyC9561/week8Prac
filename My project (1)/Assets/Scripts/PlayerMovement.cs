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
    }
}
