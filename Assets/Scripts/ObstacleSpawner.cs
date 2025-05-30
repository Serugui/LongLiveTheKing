using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab; // Prefab of the obstacle to spawn
    [SerializeField] float obstacleSpawnTime = 1f; // Time interval between spawns

    int obstaclesSpawned = 0;

    void Start()
    {

        // Start the coroutine to spawn obstacles
        StartCoroutine(SpawnObstacleRoutine());
    }

    IEnumerator SpawnObstacleRoutine()
    {
        while (obstaclesSpawned < 5)
        {            
            yield return new WaitForSeconds(obstacleSpawnTime);
            Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
            obstaclesSpawned++;

        }

    }
        
    

}
