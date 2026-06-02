using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    private float timer = 60f; // Variable decimal para la cuenta regresiva
    private UIManager uiManager;
    private bool isFinished = false;

    void Start()
    {
        // Buscamos el UIManager en la escena para poder enviarle el tiempo
        uiManager = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        if (isFinished) return;

        if (timer > 0)
        {
            // Restamos el tiempo frame a frame
            timer -= Time.deltaTime;
            
            // Enviamos el valor procesado al UIManager
            if (uiManager != null)
            {
                uiManager.UpdateTimer(timer);
            }
        }
        else
        {
            timer = 0;
            if (uiManager != null)
            {
                uiManager.UpdateTimer(timer);
            }
            isFinished = true;
            Debug.Log("¡Tiempo terminado!");
        }
    }
}