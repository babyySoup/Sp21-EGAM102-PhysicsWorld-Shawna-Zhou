using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontBackFriction : MonoBehaviour
{
    //set up for a game object that triggers the "drag"
    public float Drag;
    public string Dragger;
    //using physics
    private Rigidbody2D thisRigidbody2D;

    private void Start()
    {
        //using rigidbody from unity
        thisRigidbody2D = GetComponent<Rigidbody2D>();
    }
    //OnTriggerStay is important, it is using collision 
    private void OnTriggerStay2D(Collider2D collision)
    {
        //if the Dragger moves through the game object, create collion
        if(collision.gameObject.name == Dragger)
        {
        //adding force and making the game object move
        //using velocity 
            Vector3 velocityOfDragger = collision.gameObject.GetComponent<Rigidbody2D>().velocity;
            thisRigidbody2D.AddForce(Drag * velocityOfDragger);

        }
    }
}
