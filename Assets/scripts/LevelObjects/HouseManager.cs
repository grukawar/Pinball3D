using UnityEngine;
using System.Collections;

public class HouseManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject ParticleEffect;
    public GameObject Flash;
    public bool spawned = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            if (spawned == false)
            {
                Instantiate(ball, transform.position, Quaternion.identity);
                spawned = true;
                Instantiate(Flash, transform.position, Quaternion.identity);
            }
            
            Instantiate(ParticleEffect, transform.position, Quaternion.identity);
           

        }
    }
}
