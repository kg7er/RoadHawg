using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameObject slowCar;
    public float maxY, minY;
    public float randomX;
    public float timeBetweenSpawn;
    private float spawnTime;

   
    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        if (Random.value > 0.5f) // coin flip odds
            randomX = -1.5f;
        else
            randomX = 2.25f;
        Debug.Log(randomX);

        float randomY = Random.Range(minY, maxY);

        Instantiate(slowCar, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
