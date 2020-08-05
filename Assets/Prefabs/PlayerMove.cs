using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0f;
    private Rigidbody2D rb;
    float x;
    float y;

    public float rightLimit;
    public float leftLimit;
    public float bottomLimit;
    public float topLimit;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(Vector3.zero);
        bottomLimit = bottomLeft.y;
        leftLimit = bottomLeft.x;

        Vector3 topRight = Camera.main.ViewportToWorldPoint(Vector3.one);
        topLimit = topRight.y;
        rightLimit = topRight.x;

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

        Vector3 desiredPosition = transform.position + new Vector3(x,y,0f) * speed * Time.fixedDeltaTime;

        desiredPosition.x = Mathf.Clamp(desiredPosition.x, leftLimit, rightLimit);

        desiredPosition.y = Mathf.Clamp(desiredPosition.y, bottomLimit, topLimit);

        rb.MovePosition(desiredPosition);



    }
}
