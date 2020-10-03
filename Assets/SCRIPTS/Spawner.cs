using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject collectible;
    float randomX;
    float randomY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randomX = Random.Range(-8.4f, 8.4f);
            randomY = Random.Range(-2.5f, 4f);
            whereToSpawn = new Vector2(randomX, randomY);
            Instantiate(collectible, whereToSpawn, Quaternion.identity);
        }
    }
    
}
