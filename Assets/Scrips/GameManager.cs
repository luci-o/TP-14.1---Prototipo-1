using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Requisito: Librería de escenas para el reinicio

public class GameManager : MonoBehaviour
{
    private float timer = 60f; // Cuenta regresiva[cite: 1]
    private UIManager uiManager;
    private bool isFinished = false; // Control de fin de juego[cite: 1]

    void Start()
    {
        // CRUCIAL: Restablecer la velocidad del juego para que no inicie congelado[cite: 3]
        Time.timeScale = 1f; 
        
        uiManager = FindObjectOfType<UIManager>(); //[cite: 1]
    }

    void Update()
    {
        // Sistema de Reinicio: Si el juego terminó y presionás R, recarga la escena[cite: 3]
        if (isFinished)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); //[cite: 3]
            }
            return; // Detiene la ejecución del resto del Update[cite: 1]
        }

        // Cuenta regresiva[cite: 1]
        if (timer > 0)
        {
            timer -= Time.deltaTime; //[cite: 1]
            if (uiManager != null)
            {
                uiManager.UpdateTimer(timer); //[cite: 1]
            }

            // Si el tiempo llega a cero, activa GAME OVER[cite: 3]
            if (timer <= 0)
            {
                GameOver();
            }
        }
    }

    // Ordena al UIManager activar GAME OVER y congela el juego[cite: 3]
    public void GameOver()
    {
        isFinished = true;
        if (uiManager != null)
        {
            uiManager.MostrarPantallaGameOver(); //[cite: 3]
        }
        Time.timeScale = 0f; // Congela el paso del tiempo[cite: 3]
    }

    // Ordena al UIManager activar WIN y congela el juego[cite: 3]
    public void WinGame()
    {
        isFinished = true;
        if (uiManager != null)
        {
            uiManager.MostrarPantallaWin(); //[cite: 3]
        }
        Time.timeScale = 0f; // Congela el paso del tiempo[cite: 3]
    }
}