using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prototype2;
namespace Prototype2
{
    public class PlayerCollision : MonoBehaviour
    {
        public PlayerMovement playerMovement;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter(Collision collision)
        {
            if(/*collision.*/GetComponent<Collider>().tag == "Obstacle")
            {
                playerMovement.enabled = false;
                FindObjectOfType<GameManager>().GameOver();
            }
        }
    }
}
