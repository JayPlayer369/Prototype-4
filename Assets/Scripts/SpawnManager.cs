using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnRange = 9;
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, new Vector3(0, 0, 6), enemyPrefab.transform.rotation);
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 GenerateSpawnPosition ()
    {
       float spawnPosX = Random.Range(-spawnRange, spawnRange);
       float spawnPosZ = Random.Range(-spawnRange, spawnRange);
       Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
       return randomPos;
    }
}
