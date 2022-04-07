using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator doorAnim = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [SerializeField] private string doorOpen = "DoorOpenAnim";
    [SerializeField] private string doorClose = "DoorCloseAnim";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                doorAnim.Play(doorOpen, 0, 0.0f);
                gameObject.SetActive(false);
            }
            else if (closeTrigger)
            {
                doorAnim.Play(doorClose, 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
