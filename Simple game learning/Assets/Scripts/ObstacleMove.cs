using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float cordinateMaxLeft;
    [SerializeField] private float cordinateMaxRight;
    private bool moveRight = true;

    void Update()
    {   
        Move();
        
        //Vector3 position = new Vector3();
       float position = transform.position.x; 
        if (position > cordinateMaxRight)
        {
            moveRight = false;
        }
       
        if (position < cordinateMaxLeft)
        {
            moveRight = true;
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
}