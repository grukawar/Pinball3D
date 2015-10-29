using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour {

    HingeJoint hinge;
    JointSpring hingeSpring;

	public AudioClip FlipperUp4;
	
    void Start () {
        hinge = GetComponent<HingeJoint>();
        hingeSpring = hinge.spring;
    }
	
    public void flipperOn ()
    {
        hingeSpring.targetPosition = -45;
        hinge.spring = hingeSpring;
    }
    public void flipperOff()
    {
        hingeSpring.targetPosition = 0;
        hinge.spring = hingeSpring;
    }
	
    void Update () {

        if (Input.GetKey (KeyCode.Space)) {
			flipperOn ();
		}
		else {
			flipperOff ();
		}

	}
}
