using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    [SerializeField]
    GameManager manager;
    [SerializeField]
    private int sceneID;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        manager.ChangeScene(1);
        PlayerPrefs.SetInt("SO", sceneID);
    }
}
