using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    private float moveX;
    public float moveSpeed;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        moveX = Input.GetAxisRaw("Horizontal");
        Debug.Log(moveX);
        animator.SetBool("walk", moveX != 0);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX * moveSpeed, 0);
        bool moveHorizontaly = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;
        if (moveHorizontaly)
        {
            transform.localScale = new Vector2(Mathf.Sign(rb.velocity.x), 1);
        }

    }
}
