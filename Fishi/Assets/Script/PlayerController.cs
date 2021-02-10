using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementForce;



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