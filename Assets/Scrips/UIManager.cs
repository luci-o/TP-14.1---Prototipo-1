using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje;
    public TextMeshProUGUI textoTemporizador;
    public GameObject panelWin;
    public GameObject panelGameOver;

    private void Start()
    {
        UpdateScore(0);
    }

    public void UpdateScore(int score)
    {
        textoPuntaje.text = "Score:" + score.ToString();
    }

    public void UpdateTimer(float timeRemaining)
    {
        textoTemporizador.text = "Tiempo:" + Mathf.CeilToInt(timeRemaining).ToString();
    }
    public void MostrarPantallaWin()
    {
        if (panelWin != null) 
        {
            panelWin.SetActive(true);
        }
    }

    public void MostrarPantallaGameOver()
    {
        if (panelGameOver != null) 
        {
            panelGameOver.SetActive(true);
        }
    }
}