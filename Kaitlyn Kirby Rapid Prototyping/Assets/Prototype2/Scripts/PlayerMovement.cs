using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prototype2;
namespace Prototype2
{
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
                playerRB.AddForce(65 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey(KeyCode.A))
            {
                playerRB.AddForce(-65 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if(playerRB.position.y < -1f)
            {
                FindObjectOfType<GameManager>().GameOver();
            }
        }
    }
}
