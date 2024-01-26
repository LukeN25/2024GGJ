using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public GameObject playerObject;
    public Transform LevelStart;
    private Animator animator;

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
    }

    private void ResetPosition()
    {
        GetComponent<PlayerMovement>().enabled = true;
        gameObject.transform.position = LevelStart.position;
    }
}
