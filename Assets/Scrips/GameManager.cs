using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float timer = 60f;
    private UIManager uiManager;
    private bool isFinished = false;

    void Start()
    {
        Time.timeScale = 1f; 
        
        uiManager = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        if (isFinished)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            return;
        }
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (uiManager != null)
            {
                uiManager.UpdateTimer(timer);
            }
            if (timer <= 0)
            {
                GameOver();
            }
        }
    }
    public void GameOver()
    {
        isFinished = true;
        if (uiManager != null)
        {
            uiManager.MostrarPantallaGameOver();
        }
        Time.timeScale = 0f;
    }
    public void WinGame()
    {
        isFinished = true;
        if (uiManager != null)
        {
            uiManager.MostrarPantallaWin();
        }
        Time.timeScale = 0f;
    }
}