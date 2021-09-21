using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{

    public GameObject Enemy;
    public float sec = 5f;
    public ParticleSystem EnemyDestroyPart;
    public AudioSource Destroyy;
    public AudioClip DestroySes;
    

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
        if (other.CompareTag("Enemy"))
        {
            EnemyDestroyPart.Play(true);
            StartCoroutine(LateCall());
            Enemy.SetActive(false);
            Destroyy.PlayOneShot(DestroySes);
            FindObjectOfType<CameraShake>().Shake();
            Destroy(other.gameObject);
        }
    }

    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);
        {
           

        }
    }
}