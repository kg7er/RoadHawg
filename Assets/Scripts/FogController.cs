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
        if (ScoreManager.level < 2)
        {
            em.enabled = false;
        }
        else
        {
            em.enabled = true;
        }
            
        
    }
}
