using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DuvarKoşuKapa : MonoBehaviour
{
    protected Rigidbody rb;
    public float sec = 1f;
    public float speed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Duvar"))
        {
            rb.AddForce(transform.right * speed, ForceMode.VelocityChange);
     
            StartCoroutine(LateCall());

        }


    }
    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);

        
    }
}