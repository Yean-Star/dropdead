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

    float inputX;
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
        rb.velocity = new Vector2(inputX * moveSpeed, fallSpeed);
    }
    
    public void Die()
    {
        Debug.Log("Game over");
    }
}
