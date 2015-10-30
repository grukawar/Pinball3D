using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject spawnpoint;
    public GameObject ball;
    public Levens lifeCounter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (lifeCounter.getLeven() > 0)
        {
            if (GameObject.FindGameObjectsWithTag("Player").Length <= 0)
            {
                lifeCounter.setLeven(-1);
                Instantiate(ball, transform.position, Quaternion.identity);
            }
        }
	}
}
