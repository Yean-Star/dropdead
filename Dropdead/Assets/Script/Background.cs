using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float verticalSpeed = 0.2f;
    public float horizontalSpeed = 0.2f;

    private Renderer re;

    // Start is called before the first frame update
    void Start()
    {
        re = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * horizontalSpeed, Time.time * verticalSpeed);
        re.material.mainTextureOffset = offset;
    }
}
