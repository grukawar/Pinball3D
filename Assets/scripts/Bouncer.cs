using UnityEngine;
using System.Collections;

public class Bouncer : MonoBehaviour {

    public float bounce = 5;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.tag);
        if (collision.transform.tag == "Player")
        {
            Debug.Log(collision.transform.position);
            collision.gameObject.GetComponent<Rigidbody>().velocity = (collision.transform.transform.position - transform.position) * bounce;
        }

    }
}
