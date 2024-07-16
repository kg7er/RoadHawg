using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOther : MonoBehaviour
{
    public GameObject bush;
    public float yPos = 5f;
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

            timeBetweenSpawn = Random.Range(2f, 5f);
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void SpawnLeft()
    {
        xPos = -2.3f;
       
        Instantiate(bush, transform.position + new Vector3(xPos, yPos, 0), transform.rotation);
    }

     void SpawnRight()
    {
        xPos = 2.3f;

        Instantiate(bush, transform.position + new Vector3(xPos, yPos, 0), transform.rotation);
    }
}
