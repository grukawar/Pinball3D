﻿using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public void LeaderBoard(GameObject goToLeaderboard){
		goToLeaderboard.SetActive (true);
	}

	public void ChangeToScene(int sceneToChangeTo){
		Application.LoadLevel (sceneToChangeTo);
	}
	void Update (){
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit ();
		}
	}
}