using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public float moveInput;

    public Shooting ShootingPrefab;
    public Transform LaunchOffset;

    private Rigidbody2D rb;

    //flip the player's avatar
    private bool facingRight = true;

    ground check for jumping
    private bool isGrounded;
    public Transform groundCheck;
    public LayerMask thisGround;

    //double jump!
    private int extraJumps;
    public int extraJumpsValue;

    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {


        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, thisGround);




        moveInput = Input.GetAxis("Horizontal");
        //Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            Flip();

        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }

  
    }

    void Update()
    {

        if(isGrounded == true)
        {
            extraJumps = extraJumpsValue;

        }



        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }else if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps ==0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        //press control to fire!
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ShootingPrefab, LaunchOffset.position, transform.rotation);
        }
    }

    //the player avatar flips when facing another direction
    void Flip()
    {
        facingRight = !facingRight;

        transform.Rotate(0f, 180f, 0f);
    }

  
   
}
