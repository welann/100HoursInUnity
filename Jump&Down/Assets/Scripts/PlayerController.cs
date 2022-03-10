using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    
    public float speed;
    private float xVelocity;

    public float checkRadius;
    public LayerMask platform;
    public GameObject groundCheck;
    public bool isOnGround;

    private bool playerdead;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
    }

    void Update()
    {
        isOnGround = Physics2D.OverlapCircle(groundCheck.transform.position, checkRadius, platform);
        anim.SetBool("isOnGround",isOnGround);
        movement();
    }

    void movement()
    {
        //这里是获取键盘输入，如果换成Vertical的话，那么只能通过上下键控制左右移动
        xVelocity = Input.GetAxisRaw("Horizontal");
        
        rb.velocity=new Vector2(xVelocity*speed,rb.velocity.y);
        
        //在Animator界面设置的值
        anim.SetFloat("speed",Math.Abs(rb.velocity.x));
        
        if (xVelocity != 0)
            transform.localScale = new Vector3(xVelocity, 1, 1);

        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Fan"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 10f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("spike")) ;
            anim.SetTrigger("dead");
    }

    public void PlayerDead()
    {
        playerdead=true;
    }
    
}
