
using System;
using JetBrains.Annotations;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float Forse = 2000f;
    public float sideWayForce = 500f;
    public float backWayForce = 500f;
    public float jumpFor = 500f;

    

        // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, Forse * Time.deltaTime);
    if( Input.GetKey("d")){
     rb.AddForce(sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
}
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -backWayForce * Time.deltaTime);

        }

        if (Input.GetKey("space"))
        {
         rb.AddForce(0,jumpFor* Time.deltaTime, jumpFor* Time.deltaTime, ForceMode.VelocityChange);   
        }


        if(rb.position.y < -1f)
    { FindObjectOfType<GameManager>().EndGame();
    }
    }
    

}

