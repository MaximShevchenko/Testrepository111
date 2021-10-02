using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SocialPlatforms;
using UnityEngine.UIElements;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] 
    private float speed;
    [SerializeField]
    private float cordinateMaxLeft;
    [SerializeField] 
    private float cordinateMaxRight;
    [SerializeField] 
    private float cordinateMaxForward;
    [SerializeField] 
    private float cordinateMaxBack;
    [SerializeField]
    [Range(0,1)]
    private float timeDelay;
    private bool moveRight = true;
    
    [SerializeField] private bool moveForward = true;

    void Update()
    {   float position = transform.position.x;
        float positionZ = transform.position.z;

        Move();
        MoveZ();
        //Vector3 position = new Vector3();
      
       if (position > cordinateMaxRight)
        {
            moveRight = false;
        }
       if (position < cordinateMaxLeft)
        {
            moveRight = true;
        }

       if (positionZ > 105)
       {
           moveForward = false;
       }
       if (positionZ  < 90)
       {
           moveForward = true;
       }


    }

    private void Move()
    {
        float currentSpeed = speed;

        if (!moveRight)

        {
            currentSpeed = currentSpeed * -1;
        }

        Vector3 position = new Vector3(currentSpeed * Time.deltaTime, 0, 0);
        transform.position += position;
    }
    private void MoveZ()
    {
        float currentSpeed = speed;

       if (!moveForward)

        {
            currentSpeed = currentSpeed * -1;
        }
       Vector3 position = new Vector3(0, 0, currentSpeed * Time.deltaTime);
        transform.position += position;
    }
}