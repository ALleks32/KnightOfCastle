using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenAndCloseMenu : MonoBehaviour
{
    public GameObject MenuUI;
    public GameObject UIGame;
    
    void Start()
    {
        MenuUI = GameObject.Find("Menu");
        UIGame = GameObject.Find("UIGame");
        MenuUI.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && MenuUI.activeSelf == true)
        {
            BackGame();
        }
        else if (Input.GetKeyUp(KeyCode.Escape) && MenuUI.activeSelf == false)
        {
            MenuUI.gameObject.SetActive(true);
            UIGame.gameObject.SetActive(false);
        }
    }
    void BackGame()
    {
        MenuUI.gameObject.SetActive(false);
        UIGame.gameObject.SetActive(true);
    }

}
