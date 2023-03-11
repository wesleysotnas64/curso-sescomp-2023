using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public List<Transform> listPositions;
    public float spawnTime;
    public float currentTime;

    void Update()
    {
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= spawnTime)
        {
            currentTime = 0;

            int index = Random.Range(0, 8);

            Instantiate(enemy, listPositions[index].position, transform.rotation);
        }
    }
}
