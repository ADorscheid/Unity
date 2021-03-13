using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        // this adds a force right at the start
        // rb.AddForce(0,200,500);
    }

    // Update is called once per frame
    // physic stuff means use FixedUpdate instead of just Update
    void FixedUpdate()
    {
        // this will be a constant force on the player, but depends on the framerate.  so this will change computer to computer
        // rb.AddForce(0,0,200);

        // this accounts for this - now it'll look the same on all systems
        rb.AddForce(0,0,forwardForce*Time.deltaTime);

        // there are better ways to handle player movement that i need to look into later
        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")){
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
