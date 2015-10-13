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
}

