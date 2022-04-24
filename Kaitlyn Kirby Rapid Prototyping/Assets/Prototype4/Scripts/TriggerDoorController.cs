using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Prototype4;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] public Animator doorAnim = null; //Was private
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [SerializeField] public string doorOpen = "DoorOpenAnim"; //Was private
    [SerializeField] private string doorClose = "DoorCloseAnim";

    public UIManager uiManager;

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
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                uiManager.ShowQuestion();
                //doorAnim.Play(doorOpen, 0, 0.0f);
                gameObject.SetActive(false);
            }
            else if (closeTrigger)
            {
                    //uiManager.CorrectAnswer();
                    doorAnim.Play(doorClose, 0, 0.0f);
                    gameObject.SetActive(false);
            }
        }
    }
}
