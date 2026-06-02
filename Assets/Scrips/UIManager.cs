using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Referencias públicas a los componentes TextMeshPro de la UI
    public TextMeshProUGUI textoPuntaje;
    public TextMeshProUGUI textoTemporizador;

    // Método público para actualizar el texto del puntaje
    public void UpdateScore(int score)
    {
        textoPuntaje.text = "Score: " + score.ToString();
    }

    // Método público para actualizar el texto del cronómetro
    public void UpdateTimer(float timeRemaining)
    {
        textoTemporizador.text = Mathf.CeilToInt(timeRemaining).ToString();
    }
}