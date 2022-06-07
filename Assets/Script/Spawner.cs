using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2, 2);
    }

    void SpawnEnemy()
    {
        int index = Random.Range(0, 1);
        Instantiate(enemies[index], transform.position, transform.localRotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
