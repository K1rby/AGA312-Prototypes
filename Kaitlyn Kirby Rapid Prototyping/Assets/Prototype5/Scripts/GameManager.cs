using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanielDangToolkit;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Prototype5
{
    public class GameManager : Singleton<GameManager>
    {
        public GameObject levelCompleteUI;

        public void LevelComplete()
        {
            levelCompleteUI.SetActive(true);
        }

        public void ReloadLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }

        public void QuitGame()
        {
            Debug.Log("Quit");
            Application.Quit();
        }
    }
}
