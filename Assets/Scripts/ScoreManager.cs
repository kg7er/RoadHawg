using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text levelText;
    public Text scoreLabel;
    public Text levelLabel;
    public static int score = 0;
    public static int level = 1;
   

   

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            if (score <= 0)
                score = 0;
                //===========
            if (score < 50)
            {
                level = 1;
               levelText.GetComponent<Text>().color = new Color32(255,255,255,255); // White
            }

            else if (score >= 100)
                {
                    level = 3;
                    levelText.GetComponent<Text>().color = new Color32(255,100,70,255); // Tomato

                }
            else
                {
                    level = 2;
                    levelText.GetComponent<Text>().color = new Color32(255,215,0,255); // Gold
    
                }

            scoreText.text = score.ToString();
            levelText.text = level.ToString();
        }

    }

}
