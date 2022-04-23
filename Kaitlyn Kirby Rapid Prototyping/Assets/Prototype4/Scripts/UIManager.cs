using DanielDangToolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Prototype4
{
    public class UIManager : Singleton<UIManager>
    {
        public GameObject questionUI;

        public PlayerMovement playerMovement;
        public MouseLook mouseLook;
        public TabInputField tabInputField;
        public TriggerDoorController doorController;

        public void Update()
        {

        }

        public void ShowQuestion()
        {
            questionUI.SetActive(true);
            playerMovement.enabled = false;
            mouseLook.enabled = false;
            tabInputField.enabled = true;
        }

        public void CorrectAnswer()
        {
                doorController.doorAnim.Play(doorController.doorOpen, 0, 0.0f);
                questionUI.SetActive(false);
                playerMovement.enabled = true;
                mouseLook.enabled = true;
                tabInputField.enabled = false;
        }
    }
}
