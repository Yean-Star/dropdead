using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    Rigidbody2D _rb;
    private int[] _angle = { 0, 90, 180, 270 };
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, _angle.Length);
        transform.rotation = Quaternion.Euler(0, 0, _angle[rand]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
