using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFollowCamera : MonoBehaviour
{
    public Transform target;      
    public float smoothSpeed = 5f;
    

    private Vector3 offset;      

    void Start()
    {
       offset = transform.position - target.position;
    }

   
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        desiredPosition.z = transform.position.z;

       
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * smoothSpeed);
    }
}

