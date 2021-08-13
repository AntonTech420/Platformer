using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;
    private float moveVelocity;


    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    private bool doubleJumped;

    private Animator anim;

    private Rigidbody2D myrigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>(); 
      myrigidbody2D = GetComponent<Rigidbody2D>(); 
    }

    void FixedUpdate() 
    {
      grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); 
    }
    

    // Update is called once per frame
    void Update()
    {
        if(grounded)
            doubleJumped = false;

        anim.SetBool("Grounded", grounded);

            

      if (Input.GetKeyDown(KeyCode.W) && grounded)// if remove && grounded can fly
      {
        Jump();
      }

      if (Input.GetKeyDown(KeyCode.W) && !doubleJumped && !grounded)
      {
         Jump();
         doubleJumped = true;  
      }

      moveVelocity = 0f;


      if (Input.GetKey(KeyCode.D))
      {
        // GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        moveVelocity = moveSpeed;
      }


      if (Input.GetKey(KeyCode.A))
      {
        // GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        moveVelocity = -moveSpeed;
      }

      myrigidbody2D.velocity = new Vector2(moveVelocity, myrigidbody2D.velocity.y);

      anim.SetFloat("Speed",Mathf.Abs(myrigidbody2D.velocity.x));
    }

    public void Jump()
    {
        myrigidbody2D.velocity = new Vector2(myrigidbody2D.velocity.x, jumpHeight);
    }
      
}

