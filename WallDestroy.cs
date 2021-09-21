using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{

   
    public GameObject Wall;
    public float sec = 5f;
    public ParticleSystem EnemyDestroyPart;
    public AudioSource Destroyy;
    public AudioClip DestroySes;
    public GameObject Money2;
   

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
        if (other.CompareTag("Kick"))
        {
            EnemyDestroyPart.Play(true);
            StartCoroutine(LateCall());
            Wall.SetActive(false);
            Destroyy.PlayOneShot(DestroySes);
            FindObjectOfType<CameraShake>().Shake();
            Money2.SetActive(true);
           
        }
    }

    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);
        {
            

        }
    }
}
