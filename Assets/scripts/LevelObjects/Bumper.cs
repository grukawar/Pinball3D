using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour
{
    public GameObject poof;
    public GameObject Flash;
    public float bounce = 5;
    private LeaderBoard scoreBoard;

    void Start()
    {

        scoreBoard = GameObject.FindGameObjectWithTag("ScoreBoard").GetComponent<LeaderBoard>();
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "ball")
        {
            Vector3 scale = transform.localScale;
            scale.y = 250F; // your new value
            scale.x = 250F; 
            scale.z = 250F; 
            transform.localScale = scale;


            Instantiate(poof, transform.position, Quaternion.identity);
            Instantiate(Flash, transform.position, Quaternion.identity);


            Debug.Log(coll.transform.tag);

            if (coll.transform.tag == "Player")
            {
                Debug.Log(coll.transform.position);
                coll.gameObject.GetComponent<Rigidbody>().velocity = (coll.transform.transform.position - transform.position) * bounce;
            }
        }
    }

    void OnCollisionExit(Collision Coll)
    {
        Vector3 scale = transform.localScale;
        scale.y = 75f; // your old value
        scale.x = 75f; 
        scale.z = 75f; 
        transform.localScale = scale;
    }

}
