using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRB;
    public float movementForce = 1500f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerRB.AddForce(0, 0, movementForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            playerRB.AddForce(700 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerRB.AddForce(-700 * Time.deltaTime, 0, 0);
        }
    }
}
