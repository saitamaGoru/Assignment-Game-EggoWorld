using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemy : MonoBehaviour
{
   
    public float speed;
    public Transform turnPoint;
    public Transform center;
    public float radius;
    public LayerMask ground;
    private Vector2 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        SettingRef();
    }

    public void SettingRef()
    {
        direction = Vector2.left;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        IsGroundAhead();

    }
    public void Movement()
    {
        transform.position += new Vector3(direction.x * speed * Time.deltaTime,0f);
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(center.position, radius);
        Gizmos.DrawLine(center.position, turnPoint.position);
    }

    public void IsGroundAhead()
    {
        var groundAhead = Physics2D.Linecast(center.position, turnPoint.position, ground);
        if (!groundAhead)
            Flip();
    }

    public void Flip()
    {
        transform.localScale = new Vector3(transform.localScale.x*-1f, transform.localScale.y,0f);
        direction *=  -1f;
    }
}
