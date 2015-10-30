using UnityEngine;
using System.Collections;

public class HouseManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject ParticleEffect;
    public GameObject Flash;
    float cooldown = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        cooldown -= Time.deltaTime;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            if (cooldown <= 0)
            {
                Instantiate(ball, transform.position, Quaternion.identity);
                cooldown = 10;
                Instantiate(Flash, transform.position, Quaternion.identity);
            }
            
            Instantiate(ParticleEffect, transform.position, Quaternion.identity);

        }
    }
}
