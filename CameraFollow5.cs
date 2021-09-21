using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFollow5 : MonoBehaviour
{

    public Transform TargetObject;
    public float followDistance = 5f;
    public Slider CameraChance;
    public bool smoothedFollow = false;         
    public float smoothSpeed = 5f;
    public bool useFixedLookDirection = false;      
    public Vector3 fixedLookDirection = Vector3.one;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 lookToward = TargetObject.position - transform.position;
        if (useFixedLookDirection)
            lookToward = fixedLookDirection;


       
        Vector3 newPos;
        newPos = TargetObject.position - lookToward.normalized * followDistance;
        newPos.y = TargetObject.position.y + CameraChance.value;

        if (!smoothedFollow)
        {
            transform.position = newPos;    
        }
        else   
        {
            transform.position += (newPos - transform.position) * Time.deltaTime * smoothSpeed;
        }

        
        lookToward = TargetObject.position - transform.position;

       
        transform.forward = lookToward.normalized;
    }

}
