using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour
{
    public GameObject poof;
    public Collider force;

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
            
        }
    }

    void OnCollisionExit(Collision Coll)
    {
        Vector3 scale = transform.localScale;
        scale.y = 150F; // your old value
        scale.x = 150F; 
        scale.z = 150F; 
        transform.localScale = scale;
    }

}
