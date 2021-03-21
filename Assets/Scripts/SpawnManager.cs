using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnRangeZ = 7.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomBall), startDelay, spawnInterval);
    }
    
    void SpawnRandomBall()
    {
        Vector3 spawnPos = new Vector3(0, 11, 8 + Random.Range(-spawnRangeZ, spawnRangeZ));
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}
