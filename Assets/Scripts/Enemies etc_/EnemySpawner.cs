using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject[] Enemies;

    int randomSpawnPoint, randomEnemy;

    public static bool spawnAllowed;

    int ValueMax;

    float Tid = 1.2f;

    // Use this for initialization
    void Start()
    {
        spawnAllowed = true;

        InvokeRepeating("SpawnAnEnemy", 0f, Tid);
    }

    void SpawnAnEnemy()
    {
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(Enemies[randomEnemy], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
        }
    }
    void Update()
    {
        randomEnemy = Random.Range(0 , ValueMax);

        if (Score.scoreValue > 20)
        {
            ValueMax = 2;

            Tid = 1f;
        }    

        if (Score.scoreValue > 40)
        {
            ValueMax = 3;

            Tid = 0.8f;
        }

        if (Score.scoreValue > 60)
        {
            ValueMax = 4;

            Tid = 0.7f;
        }

        if (Score.scoreValue > 150)
        {
            Tid = 0.6f;
        }

        if (Score.scoreValue > 250)
        {
            Tid = 0.5f;
        }

        if (Score.scoreValue > 300)
        {
            Tid = 0.4f;
        }
    }
}
