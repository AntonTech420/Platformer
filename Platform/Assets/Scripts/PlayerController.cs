using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    private bool doubleJumped;

    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>();  
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


      if (Input.GetKey(KeyCode.D))
      {
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
      }


      if (Input.GetKey(KeyCode.A))
      {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
      }
      anim.SetFloat("Speed",Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }
      
}

