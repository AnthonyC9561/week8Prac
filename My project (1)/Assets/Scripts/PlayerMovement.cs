using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector3 velocity = new Vector3();

    void Update()
    {//have have script check the tag once in the Start() method, save player string and only update that player instead of checking which player moved each time 
        PlayerOneMovement();
        PlayerTwoMovement();
        transform.Translate(velocity * speed * Time.deltaTime);
    }

    private void PlayerOneMovement()
    {
        if (gameObject.tag == StringConstants.Player1)
        {
            velocity.x = Input.GetAxis(StringConstants.PlayerOneHorizontal);
            velocity.z = Input.GetAxis(StringConstants.PlayerOneVertical);
        }
    }

    private void PlayerTwoMovement()
    {
        if (gameObject.tag == StringConstants.Player2)
        {
            velocity.x = Input.GetAxis(StringConstants.PlayerTwoHorizontal);
            velocity.z = Input.GetAxis(StringConstants.PlayerTwoVertical);
        }
    }
}


