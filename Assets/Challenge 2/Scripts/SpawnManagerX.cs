using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float minSpawnInterval = 3.0f;
    private float maxSpawnInterval = 5.0f;

    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    public void SpawnRandomBall()
    {
 
        int randomIndex = Random.Range(0, ballPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        Instantiate(ballPrefabs[randomIndex], spawnPos, ballPrefabs[randomIndex].transform.rotation);

        float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);

        Invoke("SpawnRandomBall", spawnInterval);
    }
}
