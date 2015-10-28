using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LeaderBoard : MonoBehaviour {
	public float score = 0;
	public Text scoreDisplay;
	
	public void addScore (float amount){
		score += amount;
		updateScore ();
	}
	
	public void setScore(float amount) {
		score = amount;
		updateScore ();
	}
	
	public float getScore() {
		return score;
	}
	
	private void updateScore() {
		scoreDisplay.text = "Score: " + score;
	}
}