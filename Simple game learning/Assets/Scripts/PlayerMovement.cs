
using System;
using JetBrains.Annotations;
using UnityEditorInternal;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float movingSideForse = 2000f;
    public float sideLeftRIght = 500f;
    public float sideBack = 500f;
    public bool ground = false;

    public void OnGround()
   {
        ground = true;
        
   }

   
       

   // Update is called once per frame
    public void FixedUpdate()
    {
      // const float speed = 60;
     // transform.position += new Vector3(0,Time.deltaTime * speed,0);
       rb.AddForce(0, 0, movingSideForse * Time.deltaTime);
       
    if( Input.GetKey(KeyCode.D)){
        
        Vector3 velocity = rb.velocity;
        if (velocity.x < 0) //if going left
        {
            rb.velocity = new Vector3(0, velocity.y, velocity.z);
       }
        rb.AddForce(sideLeftRIght * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    if (Input.GetKey(KeyCode.A))
        {
           Vector3 velocity = rb.velocity;
           if (velocity.x > 0) //if going right
            {
               rb.velocity = new Vector3(0, velocity.y, velocity.z);
            }
            rb.AddForce(-sideLeftRIght * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    
    if (Input.GetKey(KeyCode.Space) && ground != true)
    {
        Vector3 velocity = rb.velocity;
        rb.velocity = new Vector3(0, 7, velocity.z);
        OnGround();
    }




        if(rb.position.y < -1f)
    { FindObjectOfType<GameManager>().EndGame();
    }
    }
    

}

