using UnityEngine;
using System.Collections;

public class BounceyObject : MonoBehaviour 
{

	public bool hit = false;



	void OnColliderEnter (Collision collision)
	{
		if (collision.gameObject.tag == "Player") 
		{
			hit = true;
		}
		

	}

}
