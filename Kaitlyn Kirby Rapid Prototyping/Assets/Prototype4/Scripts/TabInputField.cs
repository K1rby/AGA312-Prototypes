using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TabInputField : MonoBehaviour
{
    public TMP_InputField answerInput1; //0
    public TMP_InputField answerInput2; //1
    public TMP_InputField answerInput3; //2

    public int inputSelected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
        {
            inputSelected--;
            if (inputSelected < 0) inputSelected = 2;
            SelectInputField();
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            inputSelected++;
            if (inputSelected < 2) inputSelected = 0;
            SelectInputField();
        }
    }

    void SelectInputField()
    {
        switch (inputSelected)
        {
            case 0: answerInput1.Select();
                break;
            case 1:
                answerInput2.Select();
                break;
            case 2:
                answerInput3.Select();
                break;
        }
    }

    public void Answer1Selected() => inputSelected = 0;
    public void Answer2Selected() => inputSelected = 1;
    public void Answer3Selected() => inputSelected = 2;
}
