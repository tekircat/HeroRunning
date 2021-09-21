using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{


    public int maxHealth = 100;
    public int currentHealth;
    private bool isDead = false;
    public AudioSource EksiCan;
    public AudioClip EksiCanSes;
    public ParticleSystem EksiCanPart;

    public float sec = 5f;
   
    void Start()
    {

        currentHealth = maxHealth;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {

            TakeDamage(5);

            if (currentHealth <= 0 && !isDead)
            {
                Die();
            }

            EksiCan.PlayOneShot(EksiCanSes);
            EksiCanPart.Play(true);
            FindObjectOfType<CameraShake>().Shake();
            StartCoroutine(LateCall());
 
        }

    }
    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);
        FindObjectOfType<GameManager>().EndGame();
     

    }
    void TakeDamage(int damage)

    {
        currentHealth -= damage;
     
    }

    public void Die()
    {

        isDead = true;

    }

}
