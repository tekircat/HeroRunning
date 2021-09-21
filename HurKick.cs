using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurKick : MonoBehaviour
{
    public Animator HurKicc1;
    public GameObject Kure;
    public GameObject PlayerLives;
    public float sec = 5f;
    public GameObject Trail;
    public GameObject Kosu;

    //public CameraFollow4 cam1;
    //public CameraFollow3 cam2;


    //public float zoom;
    //public float normal;
    //public float smooth;



    //public float sec2 = 2f;

    // Start is called before the first frame update
    void Start()
    {

        //Kure.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HurKicc1.Play("DonenTekme");
            Kure.SetActive(true);
            //PlayerLives.SetActive(false);
            //transform.position = new Vector3(0,-50,35);
            StartCoroutine(LateCall());
            //StartCoroutine(LateCall2());
            //Time.timeScale = 0.4f;

            //Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, zoom, Time.deltaTime * smooth);

            //cam1.enabled = false;
            //cam2.enabled = true;

            Trail.SetActive(true);
            Kosu.SetActive(false);
        }


    }

    //IEnumerator LateCall2()
    //{

        //yield return new WaitForSeconds(sec2);

        
        //Time.timeScale = 1.0f;
        
    //}


    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);

        Kure.SetActive(false);
        //PlayerLives.SetActive(true);
        //transform.position = new Vector3(0, 0.03f, 35);
        //Time.timeScale = 1.0f;
        //Do Function here...

        //cam1.enabled = true;
        //cam2.enabled = false;

        Trail.SetActive(false);
        Kosu.SetActive(true);

        //Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, normal, Time.deltaTime * smooth);

    }


}
