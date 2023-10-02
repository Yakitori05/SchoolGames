using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    public Collider2D cd;

    private float moveX;
    private bool active = true;

    private void Start()
    {
        cd = GetComponent<Collider2D>();
    }
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!active)
        {
            return;
        }
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }

    public void Die()
    {
        active = false;
        cd.enabled = false;
    }
}
