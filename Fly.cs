using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public Animator Flyy;
    public GameObject Kure;
    public GameObject PlayerLives;
    public float sec = 5f;
    public GameObject TrailSol;
    public GameObject TrailSag;
    public GameObject Kosu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Flyy.Play("fly");
            Kure.SetActive(true);
            TrailSol.SetActive(true);
            TrailSag.SetActive(true);
            Kosu.SetActive(false);
            StartCoroutine(LateCall());

        }


    }
    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);

        Kure.SetActive(false);
        TrailSol.SetActive(false);
        TrailSag.SetActive(false);
        Kosu.SetActive(true);
        
    }
}
