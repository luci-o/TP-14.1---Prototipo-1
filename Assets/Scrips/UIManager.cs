using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //[cite: 3]

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje; //[cite: 3]
    public TextMeshProUGUI textoTemporizador; //[cite: 3]

    // Requisito: Variables públicas de tipo GameObject para arrastrar los contenedores[cite: 3]
    public GameObject panelWin;
    public GameObject panelGameOver;

    private void Start()
    {
        UpdateScore(0); //[cite: 3]
    }

    public void UpdateScore(int score)
    {
        textoPuntaje.text = score.ToString(); //[cite: 3]
    }

    public void UpdateTimer(float timeRemaining)
    {
        textoTemporizador.text = Mathf.CeilToInt(timeRemaining).ToString(); //[cite: 3]
    }

    // Requisito: Métodos públicos para activar las pantallas mediante SetActive(true)[cite: 3]
    public void MostrarPantallaWin()
    {
        if (panelWin != null) 
        {
            panelWin.SetActive(true); //[cite: 3]
        }
    }

    public void MostrarPantallaGameOver()
    {
        if (panelGameOver != null) 
        {
            panelGameOver.SetActive(true); //[cite: 3]
        }
    }
}