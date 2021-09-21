using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public  float Moneyy;
    public AudioSource Mone;
    public AudioClip MoneSes;
    public ParticleSystem MoneyPart;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moneyy = PlayerPrefs.GetFloat("Money");
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Money"))
        {
            Moneyy +=1 ;
            PlayerPrefs.SetFloat("Money", Moneyy);
            Mone.PlayOneShot(MoneSes);
            MoneyPart.Play(true);
            Destroy(other.gameObject, 0);


        }

    }
}