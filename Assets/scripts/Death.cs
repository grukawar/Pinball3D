using UnityEngine;
using System.Collections;

public class Death : Levens {
	public float valueLevens = 1;
	private Levens pinBall;

	void Start (){
		pinBall = GameObject.FindGameObjectWithTag ("Leven").GetComponent<Levens> ();
	}
	
	void OnCollisionEnter(Collision collision)
	{
		Debug.Log(collision.transform.tag);
		if (collision.transform.tag == "Death")
        {
            Destroy(gameObject);
            pinBall.removeLeven(valueLevens);
        }
	}
}
