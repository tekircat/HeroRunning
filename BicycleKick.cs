using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleKick : MonoBehaviour
{
    public Animator BisikletTekme;
    public GameObject Kure;
    public GameObject PlayerLives;
    public float sec = 5f;
    public GameObject TrailSol;
    public GameObject TrailSag;

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
            BisikletTekme.Play("BisikletTekme");
            Kure.SetActive(true);
            PlayerLives.SetActive(false);
            TrailSol.SetActive(true);
            TrailSag.SetActive(true);
            StartCoroutine(LateCall());

        }


    }
    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);

        Kure.SetActive(false);
        PlayerLives.SetActive(true);
        TrailSol.SetActive(false);
        TrailSag.SetActive(false);
        
    }
}
