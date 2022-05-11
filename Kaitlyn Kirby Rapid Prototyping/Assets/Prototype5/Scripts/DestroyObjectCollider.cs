using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prototype5;
using UnityEngine.UI;
using DanielDangToolkit;

public class DestroyObjectCollider : MonoBehaviour
{
    public int Points = 0;
    public PlayerController playerControl;

    public Animator cameraAnim = null;
    public string cameraZoom1 = "CameraAnim";
    public string cameraZoom2 = "2CameraZoom";
    public string cameraZoom3 = "3CameraZoom";

    public GameManager gameManager;

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

        if (Points == 80)
        {
            cameraAnim.Play(cameraZoom2, 0, 0.0f);
        }

        if (Points == 120)
        {
            cameraAnim.Play(cameraZoom3, 0, 0.0f);
        }

        if (Points == 200)
        {
            gameManager.LevelComplete();
        }
    }
}
