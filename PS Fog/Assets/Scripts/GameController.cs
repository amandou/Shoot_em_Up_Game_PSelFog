using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public float retryDelay;
    public int numberEnemies;
    public float startWait;
    public float spawnWait;
    public float waveWait;

    public GameObject enemy;
    public Vector3 spawnPos;

    public GameUI gameOverUI;


    private bool gameOver;
    private bool retry;

    void Start()
    {
        gameOver = false; 
        retry = false;
        ScoreScript.score = 0;
        StartCoroutine(SpawnWaves ());
    }

    void Update()
    {
        Retry();
    }


    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while(true)
        {
           
            for(int i = 0; i < numberEnemies; i++)
            {
                if(gameOver)
                {
                    retry = true;
                    break;
                }
                Vector3 spawnPosition = new Vector3 (Random.Range(-spawnPos.x,spawnPos.x),
                                                            spawnPos.y,
                                                            spawnPos.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate (enemy, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait); //tempo de espera entre espera de inimigos
            }
            yield return new WaitForSeconds(waveWait); //tempo de espera entre as waves
        }
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
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

