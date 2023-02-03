using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(randomPos());
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(Screen.width);
        //Debug.Log(Screen.height);
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
        
    }
    public IEnumerator randomPos()
    {
        while (true)
        {
            transform.position = new Vector3(Random.Range(0.0f, Camera.main.orthographicSize * 2), Random.Range(0.0f, (Camera.main.orthographicSize * 2) * Screen.width / Screen.height), 0.0f);
            yield return new WaitForSeconds(1.0f);
        }
       
    }
}
