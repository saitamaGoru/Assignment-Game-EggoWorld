using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : EnemyAnimation
{

    public Animator animator;
    public Animator animatorTwo;
    
    private void Start()
    {
        animator = GetRef("SlowSlime").GetComponent<Animator>();
        animatorTwo = GetRefTwo("Snail").GetComponent<Animator>();
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            PlayAnimation();
            GameObject slime = GameObject.Find("SlowSlime");
            Destroy(slime.gameObject,1);
            
        }
        if (other.gameObject.CompareTag("SnailEnemy"))
        {
            SnailDeath();
            GameObject snail = GameObject.Find("Snail");
            Destroy(snail.gameObject, 1);
           
        }
    }

    public override  void PlayAnimation()
    {
        animator.SetInteger("Animation",1);
    }
    public void SnailDeath()
    {
        animatorTwo.SetInteger("Animation", 1);
    }
}
