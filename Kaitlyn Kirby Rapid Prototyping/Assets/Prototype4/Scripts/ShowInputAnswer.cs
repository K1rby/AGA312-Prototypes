using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowInputAnswer : MonoBehaviour
{
    public TMP_InputField inputAnswer1;
    public TMP_InputField inputAnswer2;
    public TMP_InputField inputAnswer3;
    public TMP_InputField showAnswer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int answer;

        answer = int.Parse(inputAnswer1.text) + int.Parse(inputAnswer2.text) + int.Parse(inputAnswer3.text);

        showAnswer.text = answer.ToString();
    }
}
