using System;
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

    [SerializeField] private Transform obstacleTransform;
    
    [SerializeField] private bool moveForward = true;

    void Update()

    { var position = obstacleTransform.localPosition;
        float positionX = position.x;
        float positionZ = position.z;

        Move();
        MoveZ();
       
      
       if (positionX > cordinateMaxRight)
        {
            moveRight = false;
        }
       if (positionX < - cordinateMaxLeft)
        {
            moveRight = true;
        }

       if (positionZ > cordinateMaxForward)
       {
           moveForward = false;
       }
       if (positionZ  < - cordinateMaxBack)
       {
           moveForward = true;
       }


    }

    public void Move()
    {
        float currentSpeed = speed;

        if (!moveRight)

        {
            currentSpeed = currentSpeed * -1;
        }

        Vector3 position = new Vector3(currentSpeed * Time.deltaTime, 0, 0);
        obstacleTransform.localPosition += position;
    }
    private void MoveZ()
    {
        float currentSpeed = speed;

       if (!moveForward)

        {
            currentSpeed = currentSpeed * -1;
        }
       Vector3 position = new Vector3(0, 0, currentSpeed * Time.deltaTime);
        obstacleTransform.localPosition += position;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color= Color.red;
        var position = transform.position;

        float globalMaxLeft = - cordinateMaxLeft + position.x;
        float globalMaxRight = cordinateMaxRight + position.x;
        float globalMaxForward = cordinateMaxForward + position.z;
        float globalMaxBackward = - cordinateMaxBack + position.z;

        Vector3 point1 = new Vector3(globalMaxLeft, position.y, globalMaxBackward);
        Vector3 point2 = new Vector3(globalMaxLeft, position.y, globalMaxForward);
        Vector3 point3 = new Vector3(globalMaxRight, position.y, globalMaxForward);
        Vector3 point4 = new Vector3(globalMaxRight, position.y, globalMaxBackward);

        Gizmos.DrawLine(point1, point2);
        Gizmos.DrawLine(point2, point3);
        Gizmos.DrawLine(point3, point4);
        Gizmos.DrawLine(point4, point1);
        
        
        
    }
}