using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;

    
    // Update is called once per frame
    void Update()
    {
        if (ScoreManager.level == 1)
        {
            backgroundSpeed = 1.5f;
        }
        else if (ScoreManager.level == 2)
        {
            backgroundSpeed = 2.0f;
        }
        else
        {
            backgroundSpeed = 2.5f;
        }

        backgroundRenderer.material.mainTextureOffset += new Vector2(0f, backgroundSpeed * Time.deltaTime);
    }
}
