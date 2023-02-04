using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamOffScreen : MonoBehaviour

{
    private Vector3 camMotion;
    Camera cam;
    [SerializeField]
    GameObject player;
    public PlayerMovement playerMovement;
    public CameraScroll cameraScroll;

    void Update()
    {

        bound();
    }
    void bound()
    {
        cam = Camera.main;
        var leftBottom = (Vector2)cam.ScreenToWorldPoint(new Vector3(0, 0, cam.nearClipPlane));
        var leftTop = (Vector2)cam.ScreenToWorldPoint(new Vector3(0, cam.pixelHeight, cam.nearClipPlane));
        var rightTop = (Vector2)cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, cam.pixelHeight, cam.nearClipPlane));
        var rightBottom = (Vector2)cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, 0, cam.nearClipPlane));

        if(player.transform.position.y > leftTop.y + 1 || player.transform.position.y > rightTop.y + 1)
        {
            playerMovement.Die();
        }
        if(player.transform.position.y < rightBottom.y + 1|| player.transform.position.y < leftBottom.y + 1)
        {
            cameraScroll.TryReframePlayer();
        }
    }
}
