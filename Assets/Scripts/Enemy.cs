using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform top;
    public float shrinkSpeed;
    public Vector3 targetScale;
    public float launchForce;
    private Rigidbody2D rb;
    private bool IsShrinking = false;

    private void Update()
    {
        if (IsShrinking)
            ShrinkEnemy();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && collision.gameObject.GetComponent<Transform>().position.y > top.position.y)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            IsShrinking = true;
            Invoke("KillEnemy", 1f);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * launchForce, ForceMode2D.Impulse);
        }
        else if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHandler>().Die();
        }
    }


    private void KillEnemy()
    {
        gameObject.SetActive(false);
    }    

    void ShrinkEnemy()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, targetScale, Time.deltaTime * shrinkSpeed);
    }
}
