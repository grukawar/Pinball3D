using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject target;
    public Vector3 offset = new Vector3(0, 0, 0);
    public Vector3 middlePoint = new Vector3(0, 0, 0);
    GameObject[] pinballs;

    public void changeTarget (GameObject newTarget, Vector3 newOffset)
    {
        target = newTarget;
        offset = newOffset;
    }

	void Start () {
	}

	void Update () {
        if (target)
        {
            middlePoint = target.transform.localPosition;
        }
        else
        {
            middlePoint = new Vector3(0, 0, 0);
            pinballs = GameObject.FindGameObjectsWithTag("Player");

            foreach (GameObject ball in pinballs)
            {
                middlePoint += ball.transform.position;
            }

            middlePoint = middlePoint / pinballs.Length;
        }

        transform.localPosition -= (transform.localPosition - middlePoint) / 10 - offset;

        //transform.LookAt(middlePoint);
    }
}
