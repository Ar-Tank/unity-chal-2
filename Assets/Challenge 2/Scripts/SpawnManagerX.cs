﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay); // Start spawning with a delay
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int index = Random.Range(0, ballPrefabs.Length); // Select random ball

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);

        // Set random spawn interval between 3 to 5 seconds
        spawnInterval = Random.Range(3.0f, 5.0f);
        Invoke("SpawnRandomBall", spawnInterval); // use random interval for the next spawn
    }
}
