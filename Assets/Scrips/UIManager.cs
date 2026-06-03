using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje;
    public TextMeshProUGUI textoTemporizador;

    private void Start()
    {
        UpdateScore(0);
    }
    public void UpdateScore(int score)
    {
        textoPuntaje.text = score.ToString();
    }
    public void UpdateTimer(float timeRemaining)
    {
        textoTemporizador.text = Mathf.CeilToInt(timeRemaining).ToString();
    }
}