using UnityEngine;
using System.Collections;

public class Launchpad : MonoBehaviour {

    float charge = 0;

	void Start () {
	
	}

    void Update()
    {

        if (Input.GetKey(KeyCode.Space) && charge < 3000)
        {
            charge+=20;
        }
        else
        {
            GetComponent<Rigidbody>().AddForce(transform.up * charge);
            charge = 0;
        }

    }
}
