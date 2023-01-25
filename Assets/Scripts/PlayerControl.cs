using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rb;
    public bool isJumping = false;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            rb.MovePosition(new Vector3(transform.position.x - 5, transform.position.y, transform.position.z));
            if (!isJumping)
            {
                GetComponent<Animator>().Play("SonicRunning");
            }
        }
        if (Input.GetKey("s"))
        {
            rb.MovePosition(new Vector3(transform.position.x + 5, transform.position.y, transform.position.z));
            if (!isJumping)
            {
                GetComponent<Animator>().Play("SonicRunning");
            }
        }
        if (Input.GetKey("a"))
        {
            rb.MovePosition(new Vector3(transform.position.x, transform.position.y, transform.position.z - 5));
            if (!isJumping)
            {
                GetComponent<Animator>().Play("SonicRunning");
            }
        }
        if (Input.GetKey("d"))
        {
            rb.MovePosition(new Vector3(transform.position.x, transform.position.y, transform.position.z + 5));
            if (!isJumping)
            {
                GetComponent<Animator>().Play("SonicRunning");
            }
        }
        if (Input.GetKey("space") && !isJumping)
        {
            rb.MovePosition(new Vector3(transform.position.x, transform.position.y + 5, transform.position.z));
            isJumping = true;
        }

        if (Input.anyKey == false && isJumping == false)
        {
            GetComponent<Animator>().Play("SonicIdle");
        }
        else if (isJumping)
        {
            GetComponent<Animator>().Play("SonicJumping");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }
}
