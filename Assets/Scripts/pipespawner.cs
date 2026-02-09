using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float minY = -2f;
    public float maxY = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 1f, spawnRate);
    }

   bool isGameOver = false;

void SpawnPipe()
{
    if (isGameOver) return;

    float randomY = Random.Range(minY, maxY);
    Instantiate(pipePrefab, new Vector3(transform.position.x, randomY, 0), Quaternion.identity);
}

public void StopSpawning()
{
    isGameOver = true;
    CancelInvoke();
}

    
}
