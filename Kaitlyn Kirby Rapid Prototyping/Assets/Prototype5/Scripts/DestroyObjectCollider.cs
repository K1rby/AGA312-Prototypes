using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prototype5;

public class DestroyObjectCollider : MonoBehaviour
{
    public int Points = 0;
    public PlayerController playerControl;

    public Animator cameraAnim = null;
    public string cameraZoom1 = "CameraZoom";
    public string cameraZoom2 = "2CameraZoom";
    public string cameraZoom3 = "3CameraZoom";
    /*public Animation cameraZoom1;
    public Animation cameraZoom2;
    public Animation cameraZoom3;

    private void Start()
    {
        cameraAnim = GetComponent<Animator>();
    }*/

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        CalculateProgress();
    }

    private void CalculateProgress()
    {
        Points++;

        if (Points % 10 == 0)
        {
            StartCoroutine(playerControl.ScaleHole());
        }

        if (Points == 24)
        {
            cameraAnim.Play(cameraZoom1, 0, 0.0f);
        }

        if (Points == 40)
        {
            cameraAnim.Play(cameraZoom2, 0, 0.0f);
        }

        if (Points == 100)
        {
            cameraAnim.Play(cameraZoom3, 0, 0.0f);
        }
    }
}
