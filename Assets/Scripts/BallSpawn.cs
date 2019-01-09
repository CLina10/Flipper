using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject ball;

    void Start()
    {
        int randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        Instantiate(ball, spawnPoints[randomSpawnPoint].position, spawnPoints[randomSpawnPoint].rotation);
    }
}