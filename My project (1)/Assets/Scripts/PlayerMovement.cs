using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {

        Vector3 velocity = new Vector3();

        velocity.x = Input.GetAxis(InputAxes.Horizontal);
        velocity.z = Input.GetAxis(InputAxes.Vertical);

        transform.Translate(velocity * speed * Time.deltaTime);
    }
}
