using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneManager : MonoBehaviour
{
    public Image[] cutscenes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NextScene();
    }
    private void NextScene()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Next");
            
        }
    }
}
