using UnityEngine;
using System.Collections;

public class BigHouse : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody rb;
    
   

void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            

            rb = other.GetComponent<Rigidbody>();
            
            ball = other.gameObject;
            
            switch (Random.Range(0, 3))
            {
                case 0:
                    rb.velocity = transform.forward * 10;
                    Debug.Log("up");
                    break;
                case 1:
                    rb.velocity = transform.forward * -10;
                    Debug.Log("down");
                    break;
                case 2:
                    rb.velocity = transform.right * 10;
                    Debug.Log("right");
                    break;
                case 3:
                    rb.velocity = transform.right * -10;
                    Debug.Log("left");
                    break;
            }

        }
    }

}
