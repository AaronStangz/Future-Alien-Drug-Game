using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawn : MonoBehaviour
{
    public List<GameObject> Spawnpoints;
    public List<GameObject> Spawning;
    public float SpawnArea = 0.5f;

    void Start()
    {
        foreach (GameObject p in Spawnpoints)
        {
            Vector3 spawnPoint = new Vector3(Random.Range(-SpawnArea, SpawnArea), 0, Random.Range(-SpawnArea, SpawnArea));
            Instantiate(Spawning[Random.Range(0, Spawning.Count)], p.transform.position + spawnPoint, p.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
