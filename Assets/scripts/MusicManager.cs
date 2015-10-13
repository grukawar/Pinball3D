using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MusicManager : MonoBehaviour {
	public List<AudioClip> myList = new List<AudioClip>();
	private AudioSource source;

	void Awake(){
		source = GetComponent<AudioSource> ();
	}

	void Start(){
		//PrintListInfo ();
	}

	public void PlayAudio(int audioID, float audioVol){

		source.PlayOneShot (myList [audioID], audioVol);
	}

	void Update (){
		if (Input.GetButtonDown ("Fire1")) {
			PlayAudio(0,1);
		}
	}
	/*
	void PrintListInfo(){
		AudioClip myAudioClip = new AudioClip("Game Obj 1");
		for (int i = 0; i < 4; i++) {
			myList.Add (myAudioClip);
			Debug.Log (myList[i].name);
			Debug.Log (myList.Count);
			
			if (myList.Count == 4) {
				myList.Remove (myAudioClip);
				Debug.Log (myList[i].name);
				Debug.Log (myList.Count);
			}
		}
	}
	*/
}

