using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoolScenes : MonoBehaviour
{
    void OpenGameScene()
    {
        SceneManager.LoadScene("Level_1");
    }
    void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    void GameQuit()
    {
        Application.Quit();
    }
}
