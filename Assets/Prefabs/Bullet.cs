using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D rb;
    public float damageAmount = 10f;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Meteoro"))
        {
            Meteoro meteoro = collision.gameObject.GetComponent<Meteoro>();

            if (meteoro != null)
            {
                FindObjectOfType<Score>().addPoints(10);

                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }

        }
        else if (collision.gameObject.CompareTag("enemigo"))
        {
            Enemy enemigo = collision.gameObject.GetComponent<Enemy>();

            if (enemigo != null)
            {


                enemigo.Damage(damageAmount);
                Destroy(this.gameObject);
            }
        }
    }
}
