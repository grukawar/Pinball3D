﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public float score = 0;	
	public Text countText;

	// Update is called once per frame
	void Update () {
		//if (Input.GetKeyDown(KeyCode.Space)) {
		//	score = score + 100;
		//}
		SetCountText ();
	}

	void SetCountText (){
		countText.text = "Score: " + score.ToString();
		if (score < 0) {
			score = 0;
		}
	}
}
