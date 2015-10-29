using UnityEngine;
using System.Collections;

public class ParticleExperationSystem : MonoBehaviour {

    public float Sec = 0.2f;
    public float LifeTime = 2;
    private float ParticleDuration;
    
    void Update()
    {
        ParticleDuration += Time.deltaTime * Sec;

        if (ParticleDuration >= LifeTime)
            Destroy(gameObject);
    }
}
