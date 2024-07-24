using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameObject slowCar;
    public GameObject fastCar;
    //public float maxY, minY;
    public float xPos;
    public float yPos;
    public float timeBetweenSpawn;
    private float spawnTime; // the counter
    // public float[] gravityLevel1 = {0.0f, 0.2f, 0.1f, 0.3f};
    // public float[] gravityLevel2 = {0.15f, 0.3f, 0.2f, 0.45f};
    

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
        if (ScoreManager.level == 1)
        {
            xPos = -0.75f;
            GameObject newCar = Instantiate(fastCar, transform.position + new Vector3(xPos, yPos, 0), transform.rotation);
            newCar.GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.0f, 0.2f);
        }
        else if (ScoreManager.level == 2)
        {
           xPos = Random.Range(-0.8f, -0.6f);
           GameObject newCar = Instantiate(fastCar, transform.position + new Vector3(xPos, yPos, 0), transform.rotation);
           newCar.GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.15f, 0.35f);
        }
        else if (ScoreManager.level == 3)
        {
           xPos = Random.Range(-0.8f, -0.6f);
           GameObject newCar = Instantiate(fastCar, transform.position + new Vector3(xPos, yPos, 0), transform.rotation);
           newCar.GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.2f, 0.45f);
        }
     }
    
       


     void SpawnRight()
    {
        if (ScoreManager.level == 1)
        {
            xPos = 0.75f;
            GameObject newCar = Instantiate(slowCar, transform.position + new Vector3(xPos, yPos, 0), transform.rotation);
            newCar.GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.1f, 0.3f);
        }
        else if (ScoreManager.level == 2)
        {
           xPos = Random.Range(0.6f, 0.8f);
           GameObject newCar = Instantiate(slowCar, transform.position + new Vector3(xPos, yPos, 0), transform.rotation);
           newCar.GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.2f, 0.4f);
        }
        else if (ScoreManager.level == 3)
        {
           xPos = Random.Range(0.6f, 0.8f);
           GameObject newCar = Instantiate(slowCar, transform.position + new Vector3(xPos, yPos, 0), transform.rotation);
           newCar.GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.3f, 0.5f);
        }
     }
    
}
