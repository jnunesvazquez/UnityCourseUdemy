using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[0], spawnPos, ballPrefabs[0].transform.rotation);
    }
    private float counter = 0f;
    private float spawnInterval = 2f;
    private void Update()
    {
        counter += Time.deltaTime;
        if (counter >= spawnInterval)
        {
            //Generamos una nueva bola
            SpawnRandomBall();
            Debug.LogFormat("Hemos esperado {0} segundos", spawnInterval);
            counter = 0;
            spawnInterval = Random.Range(2, 5);
        }
    }
}
