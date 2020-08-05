using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Meteoro : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody2D rb;
    public float damageAmount = 10f ;

    public GameObject particlePrefab;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();

            if (player != null)
            {
                Instantiate(particlePrefab, transform.position, transform.rotation);
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
    

    public void destroyMeteoro()
    {
        Instantiate(particlePrefab, transform.position, transform.rotation);
                        Destroy(this.gameObject);


    }
}



