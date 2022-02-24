using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanielDangToolkit;

namespace Prototype1
{
    public class SpawnManager : Singleton<SpawnManager>
    {
        public GameObject[] obstaclePrefabs;
        private Vector3 spawnPos = new Vector3(9, 0, 0);

        private float startDelay = 2f;
        private float repeatRate = 3f;

        private Prototype1.PlayerController playerControllerScript;

        private int randomObstacle;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
            playerControllerScript = GameObject.Find("Player").GetComponent<Prototype1.PlayerController>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void SpawnObstacle()
        {
            if (playerControllerScript.gameOver == false)
            {
                randomObstacle = Random.Range(0, obstaclePrefabs.Length);
                Instantiate(obstaclePrefabs[randomObstacle], spawnPos, obstaclePrefabs[randomObstacle].transform.rotation);
            }
        }
    }
}
