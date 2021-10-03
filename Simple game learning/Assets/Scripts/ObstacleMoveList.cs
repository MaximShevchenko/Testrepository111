using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoveList : MonoBehaviour
{
    [SerializeField] private List<Vector3> points;
    void Update()
    {
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