using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    private int[] grassPenalty = {0, 10, 20, 30};
    private int[] bushPenalty = {0, 80, 80, 80};
    // private int[] potholePenalty = {0, 105, 105, 105};
   


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        playerDirection = new Vector2(directionX, 0).normalized; // original
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(playerDirection.x * playerSpeed, 0);
    }

     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Grass")   
        {
            ScoreManager.score -= grassPenalty[ScoreManager.level];
        }
        else if (collision.tag == "Bush")
        {
           ScoreManager.score -= bushPenalty[ScoreManager.level];
        }
        //  else if (collision.tag == "Pothole")
        // {
        //    ScoreManager.score -= potholePenalty[ScoreManager.level];
        // }
        else if (collision.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }
            
            
    }
}
