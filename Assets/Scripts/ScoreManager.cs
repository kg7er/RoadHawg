using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static float score = 0;

   

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            if (score <= 0)
                score = 0;
            scoreText.text = ((int) score).ToString();
        }

    }

    private void OnTestAction(int a)
        {
            Debug.Log("Action: " + a);
        }
}
