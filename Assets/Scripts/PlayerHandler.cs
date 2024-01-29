using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public GameObject playerObject;
    public Transform LevelStart;
    private Animator animator;
    float deathCount = 0f;
    public AudioSource death1;
    public AudioSource death2;
    public AudioSource death3;
    public AudioSource death4;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.tag == "Death")
        {
            Die();
        }
    }

    public void Die()
    {
        GetComponent<PlayerMovement>().enabled = false;
        animator.Play("death");
        Invoke("ResetPosition", 2f);
        deathCount = deathCount + 1;
    }

    private void ResetPosition()
    {
        GetComponent<PlayerMovement>().enabled = true;
        gameObject.transform.position = LevelStart.position;
    }

    void Update()
    {
        if(deathCount == 2)
        {
            death1.Play();
        }
        
        if(deathCount == 3)
        {
            death2.Play();
        }
        
        if(deathCount == 5)
        {
            death3.Play();
        }
        
        if(deathCount == 10)
        {
            death4.Play();
        }
    }
}
