using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputFieldScript : MonoBehaviour
{
    TMP_InputField insertAnswer;
    public TMP_Text answerText;

    // Start is called before the first frame update
    void Start()
    {
        insertAnswer = GetComponent<TMP_InputField>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayAnswer()
    {
        answerText.GetComponent<TMP_Text>().text = insertAnswer.text;
    }
}
