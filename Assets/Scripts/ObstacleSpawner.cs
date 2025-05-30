using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePrefabs; // Prefab of the obstacle to spawn
    [SerializeField] float obstacleSpawnTime = 1f; // Time interval between spawns
    [SerializeField] Transform obstacleParent;


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
            yield return new WaitForSeconds(obstacleSpawnTime);
            Instantiate(obstaclePrefab, transform.position, Random.rotation, obstacleParent);

        }

    }
        
    

}
