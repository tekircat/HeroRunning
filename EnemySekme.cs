using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySekme : MonoBehaviour
{
    public float KickForce=50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Duvar"))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * KickForce, ForceMode.Impulse);
            

        }
    }

}