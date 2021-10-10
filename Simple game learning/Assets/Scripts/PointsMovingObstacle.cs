using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsMovingObstacle : MonoBehaviour
{
    [SerializeField] private List<GameObject> objects;
    [SerializeField] private Transform childObject;
    [SerializeField] private float speed;
    Vector3 pointNext;

    private int nextPoint = 1;

    // Update is called once per frame
    void Update()
    {
        Vector3 target = objects[nextPoint].transform.localPosition;
        var direction = target - childObject.localPosition;
        direction.Normalize();
        childObject.localPosition += direction * speed * Time.deltaTime;

        var distanse = Vector3.Distance(target, childObject.localPosition);
        if (distanse < 0.1f)
        {
            nextPoint++;
            if (nextPoint == objects.Count)
            {
                nextPoint = 0;
            }
        }
    }

    private void Awake()
    {
        childObject.localPosition = objects[0].transform.localPosition;
        nextPoint = 1;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;

        for (var i = 0; i < objects.Count; i++)
        {
            var position = transform.position;
            var currentPoint = objects[i].transform.localPosition + position;

            if (i + 1 < objects.Count)
            {
                pointNext = objects[i + 1].transform.localPosition + position;
            }

            if (i + 1 > objects.Count)
            {
                pointNext = objects[0].transform.localPosition + position;
            }

            Gizmos.DrawSphere(currentPoint, 0.2f);
            Gizmos.DrawLine(currentPoint, pointNext);
        }
    }
}