using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioLevel3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.Stop("2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
