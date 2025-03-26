using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    List<Vector3> spawnPoints;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
       Transform sp = transform.Find("SpawnPositions");
        foreach(Transform child in sp)
        {
            spawnPoints.Add(child.position);
        }
        InvokeRepeating("Spawn", 0, 2);
    }
    
    void spawn()
    {
        int index = Random.Range(0, spawnPoints.Count);
        Instantiate(enemy, spawnPoints[index], Quaternion.identity);
    }
}
