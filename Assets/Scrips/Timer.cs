﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timeRemaining = 60f;
    private bool isFinished = false;

    void Start()
    {
        if (timerText == null)
        {
            timerText = GetComponent<TextMeshProUGUI>();
        }
    }

    void Update()
    {
        if (isFinished) return;

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

            timerText.text = Mathf.CeilToInt(timeRemaining).ToString();
        }
        else
        {
            timeRemaining = 0;
            timerText.text = "0";
            isFinished = true;
        }
    }
}