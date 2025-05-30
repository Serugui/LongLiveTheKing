using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject chunkPrefab;
    [SerializeField] int startingChunksAmount = 12;
    [SerializeField] Transform chunkParent;
    [SerializeField] float chunkLength = 10f; // Length of each chunk, serialized for adjustment if prefabs is bigger or smaller
    [SerializeField] float moveSpeed = 8f; // Speed at which the chunks will move
    GameObject[] chunks = new GameObject[12];

    void Start()
    {
        SpawnChunks();
    }

    void Update()
    {
        MoveChunks();
    }

    void SpawnChunks()
    {
        for (int i = 0; i < startingChunksAmount; i++)
        {
            float spawnPositionZ = CalculateSpawnPositionZ(i);
            Vector3 chunkSpawnPos = new Vector3(transform.position.x, transform.position.y, spawnPositionZ);
            GameObject newChunk = Instantiate(chunkPrefab, chunkSpawnPos, Quaternion.identity, chunkParent);

            chunks[i] = newChunk;
        }
    
    }

    float CalculateSpawnPositionZ(int i)
    {
        float spawnPositionZ;

        if(i == 0)
        {
            spawnPositionZ = transform.position.z;
        }
        else
        {
            spawnPositionZ = transform.position.z + (i* chunkLength);
        }
        return spawnPositionZ;
    }

    void MoveChunks()
    {
        for (int i = 0; i < chunks.Length; i++)
        {
            chunks[i].transform.Translate(-transform.forward * (moveSpeed *Time.deltaTime)); // Move chunks backwards at a speed of deltaTime
        }
    }
}
