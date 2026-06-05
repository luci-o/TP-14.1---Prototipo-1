using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    private int score = 0; //[cite: 2]
    private UIManager uiManager;
    private GameManager gameManager; // Referencia para darle órdenes al GameManager

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>(); //[cite: 2]
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable")) //[cite: 2]
        {
            score++; //[cite: 2]
            if (uiManager != null)
            {
                uiManager.UpdateScore(score); //[cite: 2]
            }

            Debug.Log("Objeto destruido correctamente"); //[cite: 2]
            Destroy(other.gameObject); //[cite: 2]

            // CONDICIÓN DE VICTORIA: Como es solo 1 objeto, al llegar a 1 gana[cite: 3]
            if (score >= 1)
            {
                if (gameManager != null)
                {
                    gameManager.WinGame(); // Le avisa al GameManager para congelar y mostrar WIN[cite: 3]
                }
            }
        }
    }
}