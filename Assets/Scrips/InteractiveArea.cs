using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    private int score = 0;
    private UIManager uiManager;
    private GameManager gameManager;

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            score++;
            if (uiManager != null)
            {
                uiManager.UpdateScore(score);
            }

            Debug.Log("Objeto destruido correctamente");
            Destroy(other.gameObject);
            if (score >= 1)
            {
                if (gameManager != null)
                {
                    gameManager.WinGame();
                }
            }
        }
    }
}