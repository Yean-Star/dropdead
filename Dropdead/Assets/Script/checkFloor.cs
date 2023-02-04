using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkFloor : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerMovement jumping;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumping.isJump = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        jumping.isJump = false;
    }
}
