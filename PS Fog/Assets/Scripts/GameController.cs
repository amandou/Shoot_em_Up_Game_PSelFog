using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int numberEnemies;
    public float startWait;
    public float spawnWait;
    public float waveWait;

    public GameObject enemy;
    public Vector3 spawnPos;
    void Start()
    {
       StartCoroutine(SpawnWaves ());
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while(true)
        {
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
}
