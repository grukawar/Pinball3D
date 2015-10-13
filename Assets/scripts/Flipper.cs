using UnityEngine;
using System.Collections;

public class Flipper : Score {

    HingeJoint hinge;
    JointSpring hingeSpring;

    // Use this for initialization
    void Start () {
        hinge = GetComponent<HingeJoint>();
        hingeSpring = hinge.spring;
    }

    //Powers the flippers;
    public void flipperOn ()
    {
        hingeSpring.targetPosition = -45;
        hinge.spring = hingeSpring;
    }
    //Depowers the flippers;
    public void flipperOff()
    {
        hingeSpring.targetPosition = 0;
        hinge.spring = hingeSpring;
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey (KeyCode.Space)) {
			flipperOn ();
			score = score + 100;
		}
		else {
			flipperOff ();
		}

	}
}
