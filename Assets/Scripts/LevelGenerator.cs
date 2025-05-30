using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject chunkPrefab;
    [SerializeField] int startingChunksAmount = 12;
    [SerializeField] Transform chunkParent;

    [SerializeField] float chunkLength = 10f; // Length of each chunk, serialized for adjustment if prefabs is bigger or smaller

    void Start()
    {
        for(int i = 0; i < startingChunksAmount; i++)
        {
            float spawnPositionZ;

            if (i == 0)
            {
                spawnPositionZ = transform.position.z;
            }
            else
            {
                spawnPositionZ = transform.position.z + (i * chunkLength); // Each subsequent chunk is placed after the previous one
            
            }

            Vector3 chunkSpawnPos = new Vector3(transform.position.x, transform.position.y, spawnPositionZ);
            Instantiate(chunkPrefab, chunkSpawnPos, Quaternion.identity, chunkParent);  
        }
    }

}
