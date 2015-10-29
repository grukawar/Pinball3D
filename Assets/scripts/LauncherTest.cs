using UnityEngine;
using System.Collections;

public class LauncherTest : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    void start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "ball")
        {

            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);

        }
    }
}
