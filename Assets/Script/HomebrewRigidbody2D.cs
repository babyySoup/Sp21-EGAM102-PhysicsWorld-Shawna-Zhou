using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomebrewRigidbody2D : MonoBehaviour
{
    public Vector3 Velocity;
    public Vector3 Acceleration;
    public Vector3 TotalForce;

    public Vector3 Gravity;

    public float Mass;

    private void FixedUpdate()
    {
        TotalForce += Gravity;

        transform.position += Velocity * Time.fixedDeltaTime;

        Velocity += Acceleration * Time.fixedDeltaTime;

        Acceleration = TotalForce / Mass;

        TotalForce = Vector3.zero;
    }
}
