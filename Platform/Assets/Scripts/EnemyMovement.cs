using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed;
    public bool moveRight;

    private Rigidbody2D enemyRB;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask wallIsGround;
    private bool hittingWall;

    private bool NotatEdge;
    public Transform edgeCheck;
    
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        
    }


    void FixedUpdate() 
    {
      
    }

    
    void Update()
    {
        // NotatEdge = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, wallIsGround);

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, wallIsGround);

        
        if(hittingWall /*|| !NotatEdge*/)
        moveRight = !moveRight; 

        if(moveRight)
        {
            enemyRB.velocity = new Vector2(moveSpeed, enemyRB.velocity.y);
             transform.localScale = new Vector2(-0.8f,0.8f);
        }
        else
        {
            enemyRB.velocity = new Vector2(-moveSpeed, enemyRB.velocity.y);
             transform.localScale = new Vector2(0.8f,0.8f);
        }
        
    }
}
