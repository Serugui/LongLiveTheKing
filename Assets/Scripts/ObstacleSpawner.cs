using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePrefabs; // Prefab of the obstacle to spawn
    [SerializeField] float obstacleSpawnTime = 1f; // Time interval between spawns
    [SerializeField] Transform obstacleParent;
    [SerializeField] float spawnWidth = 4f; // Width of the spawn area


    void Start()
    {

        // Start the coroutine to spawn obstacles
        StartCoroutine(SpawnObstacleRoutine());
    }

    IEnumerator SpawnObstacleRoutine()
    {
        while (true)
        {      
            GameObject obstaclePrefab = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)]; 
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnWidth, spawnWidth), transform.position.y, transform.position.z);     
            yield return new WaitForSeconds(obstacleSpawnTime);
            Instantiate(obstaclePrefab, spawnPosition, Random.rotation, obstacleParent);

        }

    }
        
    

}
