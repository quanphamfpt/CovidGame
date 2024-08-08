using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject[] items;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    private int randomSpawn = -1;


    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Time.time > spawnTime)
        {
            randomSpawn = Random.Range(0, 10);
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        switch(randomSpawn)
        {
            case 3: Instantiate(items[0], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);  break;
            case 5: Instantiate(items[1], transform.position + new Vector3(randomX, randomY, 0), transform.rotation); break;
            case 9: Instantiate(items[2], transform.position + new Vector3(randomX, randomY, 0), transform.rotation); break;
        }
    }
}
