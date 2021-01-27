using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float shootSpeed = 30f;

    //bullet shoot in the direction the MC is facing

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * shootSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collision occur?
        var enemy = collision.collider.GetComponent<Enemy>();
        if (enemy)
        //enemy take damage if the collision happens
        {
            enemy.TakeDmg(1);
        }

        Destroy(gameObject);
    }
}
