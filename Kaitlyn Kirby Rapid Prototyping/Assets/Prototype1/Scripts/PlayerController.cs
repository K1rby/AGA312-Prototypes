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

        public bool doubleJumpUsed = false;
        public float doubleJumpForce;

        private Animator playerAnim;

        public ParticleSystem explosionParticle;
        public ParticleSystem dirtParticle;

        public AudioClip jumpSound;
        public AudioClip crashSound;

        private AudioSource playerAudio;

        // Start is called before the first frame update
        void Start()
        {
            playerRB = GetComponent<Rigidbody>();
            playerAnim = GetComponent<Animator>();
            playerAudio = GetComponent<AudioSource>();
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
                dirtParticle.Stop();
                playerAudio.PlayOneShot(jumpSound, 1f);

                doubleJumpUsed = false;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && !isOnGround && !doubleJumpUsed)
            {
                doubleJumpUsed = true;
                playerRB.AddForce(Vector3.up * doubleJumpForce, ForceMode.Impulse);
                playerAnim.Play("Running_Jump", 3, 0f);
                playerAudio.PlayOneShot(jumpSound, 1f);
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isOnGround = true;
                dirtParticle.Play();
            }
            else if (collision.gameObject.CompareTag("Obstacle"))
            {
                gameOver = true;
                playerAnim.SetBool("Death_b", true);
                playerAnim.SetInteger("DeathType_int", 1);
                explosionParticle.Play();
                dirtParticle.Stop();
                playerAudio.PlayOneShot(crashSound, 1f);
            }
        }
    }
}
