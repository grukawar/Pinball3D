using UnityEngine;
using System.Collections;

public class HouseManager : MonoBehaviour
{

    public GameObject ParticleEffect;
    public GameObject Flash;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "ball")
        {
           // Vector3 scale = transform.localScale;
           // scale.y = 250F; // your new value
            //scale.x = 250F;
           // scale.z = 250F;
            //transform.localScale = scale;


            //Instantiate(poof, transform.position, Quaternion.identity);
            //Instantiate(Flash, transform.position, Quaternion.identity);

        }
    }
}
