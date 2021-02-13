using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{

    public float LifeTime;

    private float TimeOfDeath;



    void Start()
    {
        TimeOfDeath = Time.time + LifeTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimeOfDeath)
            Destroy(this.gameObject);
    }
}
