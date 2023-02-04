using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirections;
    public Animator animator;
    private Vector3 d;
    //public Vector2 MovementInput { get; set; }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
    }
    void Update()
    {
        float isMove = Mathf.Abs(Input.GetAxisRaw("Horizontal")) + Mathf.Abs(Input.GetAxisRaw("Vertical"));
        animator.SetFloat("Speed", Mathf.Abs(isMove));
        ProcessInputs();

    }
    void FixedUpdate()
    {
        d = transform.localScale;
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirections = new Vector2(moveX, moveY).normalized;
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirections.x * moveSpeed, moveDirections.y * moveSpeed);
        if (moveDirections.x < 0 && d.x > 0)
        {
            d.x = -d.x;
        }
        if (moveDirections.x > 0 && d.x < 0)
        {
            d.x = Mathf.Abs(d.x);
        }
        transform.localScale = d;
    }
}

