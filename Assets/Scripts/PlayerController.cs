using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;//detect wheter or not the player has the key pressed
    private Rigidbody2D rb;
    
    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;

    public int extraJumpsValue;
    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();//use player rigid body via script
    }

    void FixedUpdate(){
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput*speed, rb.velocity.y);
        if(!facingRight && moveInput>0){
            Flip();
        }
        else if(facingRight&&moveInput<0){
            Flip();
        }
    }


    void Update()
    {
        if(isGrounded){
            extraJumps=extraJumpsValue;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)&&extraJumps>0){
            rb.velocity = Vector2.up*jumpForce;
            extraJumps--;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)&&extraJumps==0 && isGrounded){
            rb.velocity = Vector2.up*jumpForce;
        }
    }

    void Flip(){
        
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;//get current object scale
        Scaler.x *=-1;//flip in x axis
        transform.localScale = Scaler;
    }
}
