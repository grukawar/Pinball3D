using UnityEngine;
using System.Collections;

public class Death : Menu {
	
	void Start () {
		
	}
	
	
	void OnCollisionEnter(Collision collision)
	{
		Debug.Log(collision.transform.tag);
		if (collision.transform.tag == "Death")
		{
			Destroy(gameObject);
			Application.LoadLevel("GameOver");
		}
	}
}
