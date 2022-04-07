using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanielDangToolkit;
using UnityEngine.SceneManagement;

namespace Prototype2
{
    public class GameManager : Singleton<GameManager>
    {
        bool gameEnded = false;
        public float restartDelay = 1f;

        public void GameOver()
        {
            if (gameEnded == false)
            {
                gameEnded = true;
                Invoke("Restart", restartDelay);
            }
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }
    }
}
