using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	
	
	void Update () {
		if(Input.GetKey(KeyCode.Escape)){
			Time.timeScale = 0;
		} else if (Input.GetKey(KeyCode.Space)) {
			Time.timeScale = 2;
		}
	}

	public void PauseFunction () {
		gameObject.SetActive (true);
	}
}
