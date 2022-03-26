using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype3
{
    public class PlayerController : MonoBehaviour
    {
        public Transform otherPart;
        public Transform rotationPoint;
        public Transform rotationPoint2;

        public float rotationSpeed = 30f;

        public bool rotate = false;
        //public bool isRotating = false;

        // Start is called before the first frame update
        void Start()
        {
            //transform.parent = otherPart;
            //isRotating = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (rotate == false)
                return;

            // When one capsule is rotating, it becomes the parent of the other capsule. The non-moving capsule becomes the child of the moving capsule
            if (Input.GetKey(KeyCode.Mouse1))
            {
                transform.RotateAround(rotationPoint.position, Vector3.forward, Time.deltaTime * rotationSpeed);
                otherPart.parent = transform;
            }
            else if (Input.GetKey(KeyCode.Mouse0))
            {
                transform.RotateAround(rotationPoint2.position, Vector3.forward, Time.deltaTime * rotationSpeed);
                otherPart.parent = transform;
            }
            else
            {
                otherPart.parent = null;
            }

            /*if(isRotating == true)
            {
                otherPart.parent = transform;
            }
            else
            {
                isRotating = false;
                otherPart.parent = null;
            }*/
        }

    }
}
