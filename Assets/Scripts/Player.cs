using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 1;
    public Rigidbody2D rb;
    public GameObject wall;
    public SpriteRenderer s;

    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
     
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(wall.CompareTag("wall"))
        {
            s.flipX = true;
        }
    }


}
