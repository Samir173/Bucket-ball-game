using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BallManager : MonoBehaviour
{
    public GameObject BallPrefab;         // Ball prefab reference
    public float spawnRate = 1.0f;        // Time interval for spawning balls
    public GameObject[] spawnPoints;      // Array of spawn points
    private float nextSpawnTime = 0f;
    private List<GameObject> BallObjects = new List<GameObject>();  // List to track active balls

    void Start()
    {
    }
    void Update()
    {
        // Check if it's time to spawn a new ball
        if (Time.time >= nextSpawnTime)
        {
            SpawnBall();
            nextSpawnTime = Time.time + spawnRate; // Schedule the next spawn
        }
    }

    void SpawnBall()
    {
        // Select a random spawn point
        GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Debug.Log("Selected spawn point: " + spawnPoint.name);

        // Instantiate the ball prefab at the chosen spawn point
        GameObject newBall = Instantiate(BallPrefab, spawnPoint.transform.position, Quaternion.identity);
        BallObjects.Add(newBall);
    }

    public void RemoveBall(GameObject ball)
    {
        // Safely remove a ball from the active list and destroy it
        if (BallObjects.Contains(ball))
        {
            BallObjects.Remove(ball);
            Destroy(ball);
            Debug.Log("Ball removed. Total remaining: " + BallObjects.Count);
        }
    }

    public void ClearAllBalls()
    {
        // Destroy all active balls and clear the list
        foreach (var ball in BallObjects)
        {
            if (ball != null)
                Destroy(ball);
        }
        BallObjects.Clear();
        Debug.Log("All balls cleared.");
    }
}
