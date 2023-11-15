using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownCollision : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        SpawnNewBall();
    }

    private void SpawnNewBall()
    {
        Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
    }
}
