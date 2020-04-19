using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float retryDelay;
    public int numberEnemies;
    public float startWait;
    public float spawnWait;
    public float waveWait;

    public GameObject enemy;
    public Vector3 spawnPos;

    public GameObject gameOverText;
    public GameObject retryText;

    private bool gameOver;
    private bool retry;

    void Start()
    {
        gameOver = false; 
        retry = false;
        retryText.SetActive(false);
        gameOverText.SetActive(false);
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
            if(gameOver)
            {
                retryText.SetActive(true);
                retry = true;
                break;
            }
            for(int i = 0; i < numberEnemies; i++)
            {
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
        gameOverText.SetActive(true);
        gameOver = true;
    }

    public void Retry()
    {
        if(retry)
        {
            if(Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

