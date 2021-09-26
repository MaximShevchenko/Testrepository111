using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float rotateSpeed;
    void Update()
    {
       
        transform.Rotate( Vector3.down * rotateSpeed*Time.deltaTime );

    }
}
    
