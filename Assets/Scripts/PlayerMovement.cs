using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpheight;
    private Rigidbody2D body;
    public bool grounded;

    //public Animator animator;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetKey(KeyCode.Space) && grounded)
            Jump();

        /*
        if (body.velocity.magnitude != 0f && grounded)
        {
            animator.Play("Run");
        }
        else if (body.velocity.magnitude != 0f && !grounded)
        {
            animator.Play("Jump");
        }
        else
        {
            animator.Play("Idle");
        }
        */
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpheight);
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}
