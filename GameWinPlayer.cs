using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinPlayer : MonoBehaviour
{

    public GameObject Player;
    public Animator Dance;
    public ParticleSystem WinPart;
    public AudioSource WinSes;
    public AudioSource WinSes2;
    public JoystickPlayerExample6 jp6;
    public GameObject CamAnime;
    public float sec = 1f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider İnfo)
    {

        if (İnfo.tag == "Player")
        {

           
            Dance.Play("Twist Dance");
            WinPart.Play();
            WinSes.Play();
            WinSes2.Play();
            jp6.enabled = false;
            this.GetComponent<MeshRenderer>().enabled=false;
            CamAnime.GetComponent<Animator>().enabled = true;
            StartCoroutine(LateCall());
            
           
        }

        IEnumerator LateCall()
        {

            yield return new WaitForSeconds(sec);
            FindObjectOfType<GameManager>().WinLevel();
           
        }
    }
}
