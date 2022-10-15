using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [Header("Movement Properties")]
    public float speed = 2f;
    public bool isJumping = false;
    public float force = 2f;
    public float jumpForce = 2f;
    public float airFactor = 0.5f;
    public bool isGrounded;
    public Transform groundPoint;
    public LayerMask groundLayerMask;
    public float radius;

    [Header("Animations")]
   private Animator animator;
    Rigidbody2D player;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Move();
        Jump();
        FallCheck();
    }

    private void FallCheck()
    {
        if(!isGrounded)
            animator.SetInteger("AnimationState", 2);
    }

    public void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
       

        isGrounded = Physics2D.OverlapCircle(groundPoint.position, radius, groundLayerMask);

        if ((isGrounded) && x != 0.0)
        {
            Flip(x);

            player.AddForce(Vector2.right * ((x > 0.0) ? 1.0f : -1.0f) * force * ((isGrounded) ? 1 : airFactor));
            player.velocity = Vector2.ClampMagnitude(player.velocity, speed);
            animator.SetInteger("AnimationState", 1);

        }
        if((isGrounded) && x==0)
            animator.SetInteger("AnimationState", 0);

    }

    public void Flip(float x)
    {
        switch (x)
        {
            case < 0:
                transform.localScale = new Vector3(-1.0f, 1.0f, 0.0f);
                break;
            case > 0:
                transform.localScale = new Vector3(1.0f, 1.0f, 0.0f);
                break;
        }
     }
    public void Jump()
    {
        float y = Input.GetAxisRaw("Jump");
     if (isGrounded && y>0.0f)
     {
         isJumping = true;
         player.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
         animator.SetInteger("AnimationState", 2);
     }
    }
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundPoint.position, radius);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Ground Tiles")
            isJumping = false;
    }
}
