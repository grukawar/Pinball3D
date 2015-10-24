using UnityEngine;
using System.Collections;

public class ParticleExperationSystem : MonoBehaviour {

    public float Sec = 0.2f;
    public float LifeTime = 2;
    private float ParticleDuration;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        ParticleDuration += Time.deltaTime * Sec;

        if (ParticleDuration >= LifeTime)
            Destroy(gameObject);
    }
}
