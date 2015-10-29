using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject target;
    public Vector3 offset = new Vector3(0, 0, 0);

    public void changeTarget (GameObject newTarget, Vector3 newOffset)
    {
        target = newTarget;
        offset = newOffset;
    }

	void Start () {
        target = GameObject.FindGameObjectWithTag("Player");
	}

	void Update () {
        if (target)
        {
            transform.localPosition -= (transform.localPosition - target.transform.localPosition) / 10 - offset;

            transform.LookAt(target.transform.position);
        }
	}
}
