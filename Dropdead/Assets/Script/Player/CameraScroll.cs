using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    Vector3 camMotion;
    [SerializeField]
    private float camSpeed;

    public float followSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        camMotion = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        camMotion.y -= camSpeed / 1000;
        camMotion.z = -10.0f;
        this.transform.position = camMotion;
    }
  
    public void EqualPlayer()
    {
        Debug.Log("Get on");
        Vector3 newPos = new Vector3(0.0f, player.transform.position.y, 0.0f);
        camMotion = Vector3.Slerp(camMotion, newPos, followSpeed * Time.deltaTime);
        this.transform.position = camMotion;
    }
}
