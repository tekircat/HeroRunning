using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{
    public float speed = 50f;
    
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime*speed);
    }
}
