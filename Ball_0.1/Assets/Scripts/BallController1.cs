using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController1 : MonoBehaviour

{
    public float speed = 1;
    public float jumpForce = 5;
    public float speedRotation = 1;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;

        Vector3 rotation = transform.rotation.eulerAngles;
        rotation.z -= movement * speedRotation;
        transform.rotation = Quaternion.Euler(rotation);

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.9f)
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

    }
}
