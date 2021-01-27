using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //count how many times hit

    public float HitTime;
    public float MaxHitTime = 3;
    public HealthBar Healthbar;

    void Start()
    {

        HitTime = MaxHitTime;
        
    }

    public void Update()
    {
        Healthbar.SetHealth(HitTime, MaxHitTime);
    }
    //if the collision happen for 3 times the enemy destroyes. 
    public void TakeDmg(float damage)
    {
        HitTime -= damage;
        Healthbar.SetHealth(HitTime, MaxHitTime);
        if (HitTime <= 0)
        {
            Destroy(gameObject);

        }
    }
}
