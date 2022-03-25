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


        private float sceneWidth;
        private Vector3 pressPoint;
        private Quaternion startRotation;

        // Start is called before the first frame update
        void Start()
        {
            //transform.parent = otherPart;
            //sceneWidth = Screen.width;
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

        /*private void OnMouseDown()
        {
            pressPoint = Input.mousePosition;
            startRotation = transform.rotation;
        }

        private void OnMouseDrag()
        {
            float currentDistanceBetweenMousePositions = (Input.mousePosition - pressPoint).x;
            transform.rotation = startRotation * Quaternion.Euler(Vector3.forward * (currentDistanceBetweenMousePositions / sceneWidth) * 360);
            isRotating = true;
        }*/
    }
}
