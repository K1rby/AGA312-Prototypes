using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody playerRB;
        public float jumpForce;
        public float gravityModifier;

        public bool isOnGround = true;
        public bool gameOver = false;

        private Animator playerAnim;

        // Start is called before the first frame update
        void Start()
        {
            playerRB = GetComponent<Rigidbody>();
            playerAnim = GetComponent<Animator>();
            Physics.gravity *= gravityModifier;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
            {
                playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isOnGround = false;
                playerAnim.SetTrigger("Jump_trig");
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isOnGround = true;
            }
            else if (collision.gameObject.CompareTag("Obstacle"))
            {
                gameOver = true;
                Debug.Log("Game Over");
                playerAnim.SetBool("Death_b", true);
                playerAnim.SetInteger("DeathType_int", 1);
            }
        }
    }
}
