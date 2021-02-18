using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementForce;
    public float JumpForce;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D thisrigidbody2D;
            thisrigidbody2D = GetComponent<Rigidbody2D>();
            thisrigidbody2D.AddForce(JumpForce * Vector3.up, ForceMode2D.Impulse);
        }
    }

private void FixedUpdate()
{
    if(Input.GetKey(KeyCode.D))
    {
        Rigidbody2D thisrigidbody2D;
        thisrigidbody2D = GetComponent<Rigidbody2D>();
        thisrigidbody2D.AddForce(MovementForce * Vector3.right, ForceMode2D.Force);
    }

    if (Input.GetKey(KeyCode.A))
    {
        Rigidbody2D thisrigidbody2D;
        thisrigidbody2D = GetComponent<Rigidbody2D>();
        thisrigidbody2D.AddForce(MovementForce * Vector3.left, ForceMode2D.Force);
    }
}
}