using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class PointObstacleMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentSpeed;
    [SerializeField] private float pointStart;
    [SerializeField] private float pointLeft;
    [SerializeField] private float pointRight;
    [SerializeField] private float pointForward;
    [SerializeField] private float pointBackward;
    [SerializeField] private bool moveX = true;
    [SerializeField] private bool moveZ = true;
    [SerializeField] private Transform pointMove;

    void Update()
    {
        var position = pointMove.localPosition;
        float positionX = position.x;
        float positionZ = position.z;
        currentSpeed = speed * Time.deltaTime;
        Vector3 positionLocalX = new Vector3(currentSpeed, 0, 0);
        pointMove.localPosition += positionLocalX;
                if (!moveX)
        {
            currentSpeed = currentSpeed * -1;
        }

        if (positionZ > pointForward && moveZ)
        {
            moveZ = false;
        }

        if (positionX < pointRight && moveX)
        {
            moveX = false;
        }

        if (positionX < pointStart && !moveX)
        {
           // currentSpeed = 0;
            moveZ = true;
            float speedZ = speed * Time.deltaTime;
            Vector3 positionNew = new Vector3(0, 0, speedZ);
            pointMove.localPosition += positionNew;
        }

        // Vector3 point1 = new Vector3(pointStart, position.y, pointStart);
        // Vector3 point2 = new Vector3(pointLeft, position.y, pointStart);
        // Vector3 point3 = new Vector3(pointRight, position.y, pointStart);
        // Vector3 point4 = new Vector3(pointStart, position.y, pointForward);
        // Vector3 point5 = new Vector3(pointStart, position.y, pointBackward);


        
    }


    public void Move()
    {
        float currentSpeed = speed;
        if (!moveX)
        {
            currentSpeed = currentSpeed * -1;
        }

        Vector3 position = new Vector3(currentSpeed * Time.deltaTime, 0, 0);
        pointMove.localPosition += position;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        var position = transform.position;

        float globalStartX = pointStart + position.x;
        float globalStartZ = pointStart + position.z;
        float globalLeft = pointLeft + position.x;
        float globalRight = pointRight + position.x;
        float globalForward = pointForward + position.z;
        float globalBackward = pointBackward + position.z;

        Vector3 point1 = new Vector3(globalStartX, position.y, globalStartZ);
        Vector3 point2 = new Vector3(globalLeft, position.y, globalStartZ);
        Vector3 point3 = new Vector3(globalRight, position.y, globalStartZ);
        Vector3 point4 = new Vector3(globalStartX, position.y, globalForward);
        Vector3 point5 = new Vector3(globalStartX, position.y, globalBackward);

        Gizmos.DrawLine(point1, point2);
        Gizmos.DrawLine(point1, point3);
        Gizmos.DrawLine(point1, point4);
        Gizmos.DrawLine(point1, point5);
    }
}