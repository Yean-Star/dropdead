using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject _camera;
    public GameObject rabbit;
    void Start()
    {
        StartCoroutine(randomPos());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_camera.transform.position.y + 5);
        Debug.Log(Screen.width);
        Debug.Log(Screen.height);
    }

    //public float ScreenCredentials()
    //{
    //    float height = Camera.main.orthographicSize * 2;
    //    float width = height * Screen.width / Screen.height;
    //    print(height + " " + width);
    //    return height;
    //}
    public void RandomPos()
    {
        var verticalSize = Camera.main.orthographicSize * 2.0;
        var horizontalSize = verticalSize * Screen.width / Screen.height;
    }
    public IEnumerator randomPos()
    {
        while (true)
        {
            //rabbit.transform.position = new Vector3(0.0f, _camera.transform.position.y + 5, 0.0f);
            //transform.position = new Vector3(Random.Range(0.0f, Camera.main.orthographicSize * 2), Random.Range(0.0f, (Camera.main.orthographicSize * 2) * Screen.width / Screen.height), 0.0f);
            yield return new WaitForSeconds(1.0f);
        }
       
    }
}
