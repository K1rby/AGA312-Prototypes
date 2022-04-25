using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prototype5;

public class DestroyObjectCollider : MonoBehaviour
{
    public int Points = 0;
    public PlayerController playerControl;

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
    }
}
