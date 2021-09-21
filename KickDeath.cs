using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KickDeath : MonoBehaviour
{
    /*public Animator deathKucuk;
    public Animator deathSisman;
    public Animator deathUzun;
    public Animator deathKaslı;
    public Animator deathMonster;
    public Animator SaldırKucuk;
    public Animator SaldırSisman;
    public Animator SaldırUzun;
    public Animator SaldırKaslı;
    public Animator SaldırıMonster;
    */public float KickForceForward;
    public float KickForceRigt;
    public float KickForceUp;
    // public GameObject PlayerLive;
    public GameObject Ustt;
    public GameObject enemy;
    public AudioSource Kick;
    public AudioSource Kick2;
    public AudioClip KickSes;
    public AudioClip KickSes2;
    public ParticleSystem Part;
    public float Health;
    public float sec = 5f;

    public GameObject EnemyDestroy;
    public GameObject Money2;
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
        if (other.CompareTag("Kick"))
        {
            Health--;
            //float horizontal = -Input.GetAxis("Vertical");
            //transform.Rotate(Vector3.forward, angle:horizontal * Time.deltaTime * KickForceForward);
            this.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * KickForceForward, ForceMode.Impulse);
            this.gameObject.GetComponent<Rigidbody>().AddForce(transform.right * KickForceRigt, ForceMode.Impulse);
            this.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * KickForceUp, ForceMode.Impulse);
            Kick.PlayOneShot(KickSes);
            Kick2.PlayOneShot(KickSes2);
            Part.Play(true);
            FindObjectOfType<CameraShake>().Shake();
            EnemyDestroy.SetActive(true);
            Money2.SetActive(true);
            //Time.timeScale = 2f;
            //PlayerLive.GetComponent<CapsuleCollider>().enabled = false;
            //enemyKucuk.GetComponent<Renderer>().material.color = Color.red;
            if (Health <= 0)
            {
                //this.GetComponent<CapsuleCollider>().enabled = false;
                //enemy.GetComponent<Renderer>().material.color = Color.white;
                Ustt.GetComponent<SinusoidalMove>().enabled = false;
                //this.gameObject.GetComponent<Rigidbody>().AddForce(-transform.up * -KickForce, ForceMode.Impulse);
                /*deathKucuk.Play("Falling Back Death");
                deathSisman.Play("Standing React Death Forward");
                deathUzun.Play("Zombie Death");
                deathKaslı.Play("KaslıDeath");
                deathMonster.Play("Standing Death Backward 01");
                
                this.GetComponent<EnemyMoveNav>().enabled = false;
                
                
                this.GetComponent<LookAt>().enabled = false;
                */Destroy(gameObject, 1);
                StartCoroutine(LateCall());
            }
        }

        if (other.CompareTag("KickBoom"))
        {
            Health=-10;
            this.gameObject.GetComponent<Rigidbody>().AddForce(-transform.right * KickForceForward, ForceMode.Impulse);
            this.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * KickForceRigt, ForceMode.Impulse);
            Kick.PlayOneShot(KickSes);
            Part.Play(true);
            FindObjectOfType<CameraShake>().Shake();
            //PlayerLive.GetComponent<CapsuleCollider>().enabled = false;
            //enemyKucuk.GetComponent<Renderer>().material.color = Color.red;
            if (Health <= 0)
            {
                //enemy.GetComponent<Renderer>().material.color = Color.white;
                //this.gameObject.GetComponent<Rigidbody>().AddForce(-transform.up * -KickForce, ForceMode.Impulse);
                /*deathKucuk.Play("Falling Back Death");
                deathSisman.Play("Standing React Death Forward");
                deathUzun.Play("Zombie Death");
                deathKaslı.Play("KaslıDeath");
                deathMonster.Play("Standing Death Backward 01");
                
                this.GetComponent<EnemyMoveNav>().enabled = false;
                this.GetComponent<NavMeshAgent>().enabled = false;
                this.GetComponent<CapsuleCollider>().enabled = false;
                this.GetComponent<LookAt>().enabled = false;
               */ Destroy(gameObject, 3);
            }
        }
        if (other.CompareTag("Player"))
        {
            /*SaldırUzun.Play("Zombie Punching2");
            SaldırSisman.Play("Mutant Swiping");
            SaldırKucuk.Play("Sword And Shield Kick");
            SaldırKaslı.Play("KaslıSaldır");
            SaldırıMonster.Play("Zombie Attack");
            this.GetComponent<EnemyMoveNav>().enabled = false;
            this.GetComponent<NavMeshAgent>().enabled = false;
            this.GetComponent<CapsuleCollider>().enabled = false;
*/
            StartCoroutine(LateCall());
        }

    }
    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);

        //Time.timeScale = 1f;
        /*  this.GetComponent<EnemyMoveNav>().enabled = true;
          this.GetComponent<NavMeshAgent>().enabled = true;
          this.GetComponent<CapsuleCollider>().enabled = true;
          */
        //PlayerLive.GetComponent<CapsuleCollider>().enabled = true;
    }

   
}
