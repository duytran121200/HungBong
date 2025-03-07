using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameManager gameManager;

    public void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        gameManager.check = false;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        gameManager.check = true;
        gameManager.pause.SetActive(true);
    }

    public void Countinue()
    {
        gameManager.check = false;
        gameManager.pause.SetActive(false);
        //gameManager.Create();
        //Debug.Log("Ball");
        Time.timeScale = 1;

    }

    public void MenuGame()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
