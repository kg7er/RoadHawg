using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameObject slowCar;
    public GameObject fastCar;
    public float maxY, minY;
    public float xPos;
    public float timeBetweenSpawn;
    private float spawnTime; // the counter

    void Start()
    {
        
    }

   
    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
             if (Random.value > 0.5f)
                SpawnLeft();
            else
                SpawnRight();

            timeBetweenSpawn = Random.Range(1f, 5.0f);
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void SpawnLeft()
    {
        xPos = -0.1f;
        float randomY = Random.Range(minY, maxY);

        Instantiate(fastCar, transform.position + new Vector3(xPos, randomY, 0), transform.rotation);
    }

     void SpawnRight()
    {
        xPos = 1.35f;
        float randomY = Random.Range(minY, maxY);

        Instantiate(slowCar, transform.position + new Vector3(xPos, randomY, 0), transform.rotation);
    }
}
