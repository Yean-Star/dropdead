using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    [Header("Movement Setting")]
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float fallingSpeed;
    [SerializeField]
    private float jumpHigh;

    private float tempSpeed;

    public bool isJump = false;


    float inputX;

    private void Start()
    {
        tempSpeed = -fallingSpeed;
    }
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
    }
    private void FixedUpdate()
    {
        Falling(fallingSpeed);
        TryJump();
    }

    void Inputs()
    {
        inputX = Input.GetAxis("Horizontal");
    }


    void Falling(float fallSpeed)
    {
        if(fallingSpeed > 0)
        {
          fallingSpeed = -(Mathf.Abs(fallingSpeed));
            
        }
        rb.velocity = new Vector2(inputX * moveSpeed, fallSpeed * Time.deltaTime);
        if(rb.velocity.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if(rb.velocity.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    void TryJump()
    {
        if (isJump)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpHigh, ForceMode2D.Impulse);
                fallingSpeed = 0;
            }
            
        }
        else if(!isJump)
        {
            fallingSpeed = tempSpeed;
        }
        
    }
    public void Die()
    {
        Debug.Log("Game over");
    }
}
