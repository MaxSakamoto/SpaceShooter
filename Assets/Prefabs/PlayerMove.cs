using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0f;
    private Rigidbody2D rb;
    float x;
    float y;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         x = Input.GetAxisRaw("Horizontal");

         y = Input.GetAxisRaw("Vertical");


    }

    private void FixedUpdate()
    {
       // transform.position += new Vector3(x, y, 0f) * speed * Time.deltaTime;

        rb.MovePosition(transform.position + new Vector3(x, y, 0f) * speed * Time.deltaTime);
    }
}
