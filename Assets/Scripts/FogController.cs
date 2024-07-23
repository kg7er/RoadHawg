using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogController : MonoBehaviour
{
    public ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        var em = ps.emission;
        var main = ps.main;

        if (ScoreManager.level == 1)
        {
            em.enabled = false;
        }
        else if (ScoreManager.level == 2)
        {
            em.enabled = true;
            main.startLifetime = 3.5f;
        }
        else if (ScoreManager.level == 3)
        {
            em.enabled = true;
            main.startLifetime = 4.50f;
        }
        
    }
}
