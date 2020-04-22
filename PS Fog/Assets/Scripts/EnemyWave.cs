using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour
{
    public float startWait;
    public float spawnWait;
    public float waveWait;

    public int numberEnemies;
    public int maxNumberEnemies;
    
    public Vector3 spawnPos;

    public GameObject[] enemies;


    public void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while(true)
        {
           
            for(int i = 0; i < numberEnemies; i++)
            {
                if(GameController.gameOver)
                {
                    GameController.retry = true;
                    break;
                }
                Vector3 spawnPosition = new Vector3 (Random.Range(-spawnPos.x,spawnPos.x),
                                                            spawnPos.y,
                                                            spawnPos.z);
                Quaternion spawnRotation = Quaternion.identity;
                GameObject enemy = enemies[Random.Range(0,enemies.Length)];
                Instantiate (enemy, spawnPosition, spawnRotation);

                yield return new WaitForSeconds(spawnWait); //tempo de espera entre espera de inimigos
            }
            numberEnemies++;
            if(numberEnemies > maxNumberEnemies)
            {
                numberEnemies = Random.Range(5,maxNumberEnemies);
            }
            yield return new WaitForSeconds(waveWait); //tempo de espera entre as waves
        }
    }


}
