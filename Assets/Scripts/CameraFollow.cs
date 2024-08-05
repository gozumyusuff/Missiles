using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;  
    public float smoothing = 0.125f; //cam hareket hýzý  
    public Vector3 offset; 

    void FixedUpdate()
    {
        
        Vector3 desiredPosition = target.position + offset;
        
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothing);
        transform.position = smoothedPosition;
    }
}


