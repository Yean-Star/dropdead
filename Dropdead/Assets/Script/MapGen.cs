using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGen : MonoBehaviour
{
    public GameObject[] objects;
    //private int[] _angle = { 90, 180, 270 };
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, objects.Length);
        //int rand2 = Random.Range(0, _angle.Length);
        //objects[rand].transform.rotation = Quaternion.Euler(0, 0, 90);
        Instantiate(objects[rand], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
