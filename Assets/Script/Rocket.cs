using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    //set the variables that we are going to use for the code
    public Vector3 RocketForce;
    public float RocketDuration;

    public float ExplosionDelay;
    public int NExplosionPieces;
    public float ExplosionForce;
    //call the prefab
    public GameObject ExplosionPiecePrefab;

    //set interface
    private float RocketCutoffTime;
    private float ExplosionTime;



    void Start()
    {
        RocketCutoffTime = Time.time + RocketDuration;
        ExplosionTime = Time.time + ExplosionDelay;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Time.time < RocketCutoffTime)
            GetComponent<HomebrewRigidbody2D>().TotalForce += RocketForce;
        //check over and over where if it reached the explosion time
        if(Time.time > ExplosionTime)
        {//if yes then the rocket explode
            GameObject newExplosionPiece; 
            for (int i = 0; i < NExplosionPieces; i++)
            {
                //transform the positions using Rigidbody2D
                newExplosionPiece = Instantiate(ExplosionPiecePrefab);
                newExplosionPiece.transform.position = this.transform.position;
                newExplosionPiece.GetComponent<HomebrewRigidbody2D>().Velocity = this.GetComponent<HomebrewRigidbody2D>().Velocity;
                newExplosionPiece.GetComponent<HomebrewRigidbody2D>().TotalForce = ExplosionForce * Random.insideUnitCircle;
            }
            Destroy(this.gameObject);
        }
    }
}
