using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Levens : MonoBehaviour {
	public float leven = 3;
	public Text levenDisplay;
	
	public void removeLeven (float amount){
		leven -= amount;
		updateLeven ();
	}
	
	public void setLeven(float amount) {
		leven = amount;
		updateLeven ();
	}
	
	public float getLeven() {
		return leven;
	}
	
	private void updateLeven() {

		levenDisplay.text = leven + " X";
	}
}
