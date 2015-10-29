using UnityEngine;
using System.Collections;

public class BigHouse : MonoBehaviour
{
    public Transform ball;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ball = other.gameObject.transform;
            Debug.Log(ball);
        }
    }

}
