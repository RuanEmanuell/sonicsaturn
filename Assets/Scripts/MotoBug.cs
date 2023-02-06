using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoBug : MonoBehaviour
{
    public Rigidbody motoBugRb;
    public bool wall = false;
    void Update()
    {
        motoBugRb.AddForce(-30000 * Time.deltaTime, 0, 0);
        if (wall == false)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(0, 0, 0), new Vector3(0, 0, 0));
        }
        else
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(180, 0, 0), new Vector3(-90, 0, 0));
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            wall = true;
        }
        else
        {
            wall = false;
        }
    }
}
