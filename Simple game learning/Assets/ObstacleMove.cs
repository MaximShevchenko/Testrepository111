using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxLeft;
    [SerializeField] private float maxRight;
    [SerializeField] private bool moveRight = true;

    void Update()
    {
        Move();
        
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