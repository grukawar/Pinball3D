using UnityEngine;
using System.Collections;

public class Bouncer : MonoBehaviour {
	
	public float bounce = 0;
	public float valueScore = 50;
	private LeaderBoard scoreBoard;
	
	void Start (){
		scoreBoard = GameObject.FindGameObjectWithTag ("ScoreBoard").GetComponent<LeaderBoard>();
	}
	
	void OnCollisionEnter(Collision collision){

		Debug.Log(collision.transform.tag);

		if (collision.transform.tag == "Player"){
			scoreBoard.addScore(valueScore);
			Debug.Log(collision.transform.position);
			collision.gameObject.GetComponent<Rigidbody>().velocity = (collision.transform.transform.position - transform.position) * bounce;
		}
		
	}
	
}
