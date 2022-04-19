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

        public TMP_Text[] numberText;  //The text that is between the +'s. Will change when buttons are pressed
        public int numberInput;

        public void Update()
        {
           //numberInput = numberText.ToString();
        }

        public void ShowQuestion()
        {
            questionUI.SetActive(true);
            playerMovement.enabled = false;
            mouseLook.enabled = false;
        }

        public void CorrectAnswer()
        {
            questionUI.SetActive(false);
            playerMovement.enabled = true;
            mouseLook.enabled = true;
        }

        /*public void GenerateButton()
        {
            numberInput += 1;
        }*/
    }
}
