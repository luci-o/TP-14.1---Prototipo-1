using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    private float timer = 60f;
    private UIManager uiManager;
    private bool isFinished = false;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        if (isFinished) return;

        if (timer > 0)
        {

            timer -= Time.deltaTime;
            if (uiManager != null)
            {
                uiManager.UpdateTimer(timer);
            }
        }
}}