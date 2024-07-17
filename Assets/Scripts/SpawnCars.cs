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
    

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
             if (Random.value > 0.5f)
                SpawnLeft();
            else
                SpawnRight();

            timeBetweenSpawn = Random.Range(0.5f, 5.0f);
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void SpawnLeft()
    {
        xPos = -0.75f;
        float randomY = Random.Range(minY, maxY);

        GameObject newCar = Instantiate(fastCar, transform.position + new Vector3(xPos, randomY, 0), transform.rotation);
        newCar.GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.0f, 0.2f);
    }

     void SpawnRight()
    {
        xPos = 0.75f;
        float randomY = Random.Range(minY, maxY);

        GameObject newCar = Instantiate(slowCar, transform.position + new Vector3(xPos, randomY, 0), transform.rotation);
        newCar.GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.05f, 0.25f);
    }
}
