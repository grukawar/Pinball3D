using UnityEngine;
using System.Collections;

public class Bouncer : MonoBehaviour {
	
	public float valueScore = 50;
	private LeaderBoard scoreBoard;
	
	void Start (){
		scoreBoard = GameObject.FindGameObjectWithTag ("ScoreBoard").GetComponent<LeaderBoard>();
	}
	
	void OnCollisionEnter(Collision collision){

		if (scoreBoard && collision.transform.tag == "Player"){
			scoreBoard.addScore(valueScore);
		}
		
	}
	
}
