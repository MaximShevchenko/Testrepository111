using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

public class ObstacleMoveList : MonoBehaviour
{
    [SerializeField] private List<Vector3> points;
    [SerializeField] private Transform childObject;
    private int nextPoint = 1;

    [SerializeField] private float speed;

    void Update()
    {
        Vector3 target = points[nextPoint];
        var direction = target - childObject.localPosition;
        direction.Normalize();
        childObject.localPosition += direction * speed * Time.deltaTime;

        var distanse = Vector3.Distance(target, childObject.localPosition);
        if (distanse < 0.1f)
        {
            nextPoint++;
            if (nextPoint == points.Count)
            {
                nextPoint = 0;
            }
        }
    }


    private void Awake()
    {
        childObject.localPosition = points[0];
        nextPoint = 1;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        for (var i = 0; i < points.Count; i++)
        {
            var position = transform.position;
            Vector3 currentPoint = points[i] + position;

            Vector3 nextPoint;
            if (i + 1 < points.Count)
            {
                nextPoint = points[i + 1] + position;
            }
            else
            {
                nextPoint = points[0] + position;
            }

            Gizmos.DrawSphere(currentPoint, 0.2f);
            Gizmos.DrawLine(currentPoint, nextPoint);
        }

       
    }
}