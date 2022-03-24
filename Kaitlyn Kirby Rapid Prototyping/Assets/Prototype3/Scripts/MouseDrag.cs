using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public float rotationSpeed = 1f;

    /*public Transform otherPart;
    public Transform rotationPoint;
    public Transform rotationPoint2;

    public bool rotate = false;*/

    /*Vector3 offset;

    private void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
    }

    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }*/

    /*void Update()
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
    }*/

    private void OnMouseDrag()
    {
        float xAxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float yAxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.Rotate(Vector3.down, xAxisRotation);
        transform.Rotate(Vector3.right, yAxisRotation);

        //transform.RotateAround(rotationPoint.position, Vector3.forward, Time.deltaTime * rotationSpeed);
        //transform.RotateAround(rotationPoint2.position, Vector3.forward, Time.deltaTime * rotationSpeed);
    }
}
