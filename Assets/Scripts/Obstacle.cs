using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border" || collision.tag == "Obstacle" || collision.tag == "Player")  
            // Bottom Border or another obstacle or the player
        {
            Destroy(this.gameObject);
            ScoreManager.score += 5;
        } 
    }
}
