using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManagerScript : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float spawnTimer;
    public float spawnRate;
    public Transform[] spawnPoints;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("SpawnEnemy", spawnRate, spawnRate);
	}
	
	// Update is called once per frame
	void Update ()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {

            SpawnEnemy();
            spawnTimer = 3;
        }
		
	}

    // Spawns an enemy at the spawn point.
    void SpawnEnemy()
    {
        /*if(player.PlayerHealthScript.health <= 0f)
        {
            return;
        }*/
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

        
    }
}
