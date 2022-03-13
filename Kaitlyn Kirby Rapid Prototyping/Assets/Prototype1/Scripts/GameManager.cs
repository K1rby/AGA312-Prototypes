using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanielDangToolkit;
using Prototype1;

namespace Prototype1
{
    public class GameManager : Singleton<GameManager>
    {
        public float score;
        private PlayerController playerControllerScript;

        public Transform startingPoint;
        public float lerpSpeed;

        private void Start()
        {
            playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
            //score = 0;

            playerControllerScript.gameOver = true;
            StartCoroutine(PlayIntro());
        }

        private void Update()
        {

        }

        IEnumerator PlayIntro()
        {
            Vector3 startPos = playerControllerScript.transform.position;
            Vector3 endPos = startingPoint.position;
            float journeyLength = Vector3.Distance(startPos, endPos);
            float startTime = Time.time;

            float distanceCovered = (Time.time - startTime) * lerpSpeed;
            float fractionOfJourney = distanceCovered / journeyLength;

            playerControllerScript.GetComponent<Animator>().SetFloat("Speed_Multiplier", 0.5f);

            while (fractionOfJourney < 1)
            {
                distanceCovered = (Time.time - startTime) * lerpSpeed;
                fractionOfJourney = distanceCovered / journeyLength;
                playerControllerScript.transform.position = Vector3.Lerp(startPos, endPos, fractionOfJourney);
                yield return null;
            }

            playerControllerScript.GetComponent<Animator>().SetFloat("Speed_Multiplier", 1f);
            playerControllerScript.gameOver = false;
        }
    }
}
