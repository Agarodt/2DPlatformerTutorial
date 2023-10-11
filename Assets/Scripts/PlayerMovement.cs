using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveX; 
    private float moveY; 
    private Rigidbody2D rb;
    public float speed = 5;
    public float jumpForce = 0;
    Animator anim;
    bool run;


    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       anim = GetComponent<Animator>();

    }

    void Update()
    {
      // moveX = Input.GetAxisRaw("Horizontal");
      //moveY = Input.GetAxisRaw("Vertical");

      if (Input.GetKeyDown("a"))
      {
        Left();
      }
      if (Input.GetKeyUp("a"))
      {
        Stop();
      }
      if (Input.GetKeyDown("d"))
      {
        Right();
      }
      if (Input.GetKeyUp("d"))
      {
        Stop();
      }

      rb.velocity = new Vector2(moveX * speed, moveY * jumpForce); 
      
      ////Flip

      if (moveX < 0)
      {
        transform.localRotation = Quaternion.Euler(0,180,0);
      }
      if (moveX > 0)
      {
        transform.localRotation = Quaternion.Euler(0,0,0);
      }

      ///Animation

      if (moveX != 0)
      {
        run = true;
      }
      else
      {
        run = false;
      }

      anim.SetBool("isRunAnim", run);


    }

    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "Salami")
      {
        PlayerBullets.instance.bullets += 10;
        Destroy(other.gameObject);
      }
    }
    
   
    void OnTriggerStay2D(Collider2D other)
    {
      if (other.tag == "Ground")
      {
        jumpForce = 20;
      }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
      if (other.tag == "Ground")
      {
        StartCoroutine(Jump());
      }
    }

    IEnumerator Jump()
    {
      yield return new WaitForSeconds(0.1f);
      jumpForce = 0;
    }

    public void Left()
    {
      moveX = -1;
    }

    public void Right()
    {
      moveX = 1;
    }

    public void Stop()
    {
      moveX = 0;
    }

    public void Up()
    {
      moveY = 1;
    }

    public void Down()
    {
      moveY = 0;
    }


    
}
