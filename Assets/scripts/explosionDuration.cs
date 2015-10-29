using UnityEngine;
using System.Collections;

public class explosionDuration : MonoBehaviour {

	public float Sec = 0.2f;
	public float burn = 2;
	private float fireDuration;

	void Update () 
	{
		fireDuration += Time.deltaTime * Sec;

		if (fireDuration >= burn)
			Destroy (gameObject);
	}
}
