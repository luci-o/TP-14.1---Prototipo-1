using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InteractiveArea : MonoBehaviour
{
    private int score = 0; // Variable entera para el puntaje
    private UIManager uiManager;

    private void Awake()
    {
        // Almacenamos la referencia del UIManager al arrancar
        uiManager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Mantenemos el tag que ya usabas (o "Collectible" si lo cambiaste en Unity)
        if (other.CompareTag("Coleccionable"))
        {
            score++; // Incrementa la variable en una unidad
            
            // Llamamos al método del UIManager para actualizar la pantalla
            if (uiManager != null)
            {
                uiManager.UpdateScore(score);
            }

            Debug.Log("Objeto destruido correctamente. Puntos: " + score);
            Destroy(other.gameObject); // El objeto se destruye
        }
    }
}