using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeColor : MonoBehaviour
{
    public Color black = Color.black;
    public Color self;
    
    public Camera cam;
    public float duration = 3.0f;
    private float t;

    private void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }

    private void Update()
    {
        
        t = Mathf.PingPong(Time.time, duration) / duration;
        cam.backgroundColor = Color.Lerp(self, black, t);
        if (t > 0.95f)
        {
            self = Color.black;
        }
    }
}
