using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject obstaclePrefab;
        private Vector3 spawnPos = new Vector3(8, 1, 0);

        private float startDelay = 2f;
        private float repeatRate = 2f;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("SpawnObstacle", startDelay, repeatRate); 
        }

        // Update is called once per frame
        void Update()
        {

        }

        void SpawnObstacle()
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
