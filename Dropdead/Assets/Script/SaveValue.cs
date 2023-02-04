using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveValue : MonoBehaviour
{
    public InputField textBox;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void saveSO()
    {
        PlayerPrefs.SetInt("SO", 1);
        Debug.Log("NUM" + PlayerPrefs.GetInt("SO"));
    }
}
