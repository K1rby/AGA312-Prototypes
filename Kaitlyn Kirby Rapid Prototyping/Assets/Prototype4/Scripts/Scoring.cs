using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Prototype4
{
    public class Scoring : JMC
    {
        TextMeshProUGUI scoreDifference;

        float lastRoundScore = 50;
        float thisRoundScore = 88;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void GetScoreDifference()
        {
            scoreDifference.text = "Youn change is: " + PercentageChange(lastRoundScore, thisRoundScore);
        }
    }
}
