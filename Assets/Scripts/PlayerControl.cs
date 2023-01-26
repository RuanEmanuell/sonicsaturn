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
            rb.AddForce(-20000 * Time.deltaTime, 0, 0);
            if (!isJumping)
            {
                GetComponent<Animator>().Play("SonicRunning");
            }
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(20000 * Time.deltaTime, 0, 0);
            if (!isJumping)
            {
                GetComponent<Animator>().Play("SonicRunning");
            }
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -20000 * Time.deltaTime);
            if (!isJumping)
            {
                GetComponent<Animator>().Play("SonicRunning");
            }
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, 20000 * Time.deltaTime);
            if (!isJumping)
            {
                GetComponent<Animator>().Play("SonicRunning");
            }
        }
        if (Input.GetKey("space") && !isJumping)
        {
            rb.AddForce(0, 250000 * Time.deltaTime, 0);
            isJumping = true;
        }

        if (Input.anyKey == false && isJumping == false)
        {
            GetComponent<Animator>().Play("SonicIdle");
            rb.velocity = new Vector3(0, 0, 0);
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
