using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3f;
    public float jumpPower = 2f;
    
    private Rigidbody2D rb;
    [SerializeField]private SpriteRenderer sr;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * (speed * Time.deltaTime));
            sr.flipX = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * (speed * Time.deltaTime));
            sr.flipX = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            rb.velocity = Vector2.up * jumpPower;
        }
        else if (collision.gameObject.CompareTag("OncePlatform"))
        {
            rb.velocity = Vector2.up * jumpPower;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Batut"))
        {
            rb.velocity = Vector2.up * jumpPower;
        }
    }
}
