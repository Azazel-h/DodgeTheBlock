using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    public GameObject Counter;
    public ScoreText scoreText;

    public float timeBetweenWaves = 1.5f;
    private float timeToSpawn = 2f;

    void FixedUpdate()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            Instantiate(Counter, spawnPoints[0].position, Quaternion.identity);
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void SpawnBlocks()
    {
        scoreText.FirstSpawned = true;
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }  
        } 
    }
}
