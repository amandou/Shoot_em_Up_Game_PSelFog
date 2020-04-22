using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public EnemyWave waveGenerator;

    public GameUI gameOverUI;

    public static bool gameOver;
    public static bool retry;

    void Start()
    {
        gameOver = false; 
        retry = false;
        ScoreScript.score = 0;
        waveGenerator.Start();
    }

    void Update()
    {
        Retry();
    }

    public void GameOver()
    {
        gameOverUI.Show();
        gameOver = true;
        
    }

    public void Retry()
    {
        if(retry)
        {
            if(Input.GetKeyDown(KeyCode.R) || Input.GetMouseButtonDown(0))
            {
                HpSystem.hp=3;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}

