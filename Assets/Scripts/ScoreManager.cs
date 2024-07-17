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
    //public string[] levelColor = {"black","white","orange","red"};
   

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
                //levelText.GetComponent<Text>().color = new Color(224,224,224); //light gray
            }

            else if (score >= 250)
                {
                    level = 3;
                //    levelText.GetComponent<Text>().color = new Color(220,20,60); //crimson
                }
            else
                {
                    level = 2;
                    // levelText.GetComponent<Text>().color = new Color(255,165,0); //orange

                }

            scoreText.text = score.ToString();
            levelText.text = level.ToString();
        }

    }

}
