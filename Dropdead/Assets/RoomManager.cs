using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public RoomSO room1, room2 ,room3;
    void Start()
    {
        int pint = PlayerPrefs.GetInt("SO");
        if(pint == 1)
        {
            Instantiate(room1.floor, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(room1.table, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(room1.player, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(room1._wall, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(room1.Chair, new Vector3(-1.4f, 1.2f, -9.90f), Quaternion.identity);
            Instantiate(room1.Doll, new Vector3(-0.1f, 0.6f, -9.90f), Quaternion.identity);
            Instantiate(room1.PC, new Vector3(-0.09f, 0.6f, -9.90f), Quaternion.identity);
        }
        if (pint == 2)
        {
            Instantiate(room2.floor, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(room2.table, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(room2.player, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(room2._wall, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(room2.Chair, new Vector3(-1.4f, 1.2f, -9.90f), Quaternion.identity);
            Instantiate(room2.Doll, new Vector3(-0.1f, 0.6f, -9.90f), Quaternion.identity);
            Instantiate(room2.PC, new Vector3(-0.09f, 0.6f, -9.90f), Quaternion.identity);
        }
        if(pint == 3)
        {
            Instantiate(room3.floor, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(room3.table, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(room3.player, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(room3._wall, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(room3.Chair, new Vector3(-1.4f, 1.2f, -9.90f), Quaternion.identity);
            Instantiate(room3.Doll, new Vector3(-0.1f, 0.6f, -9.90f), Quaternion.identity);
            Instantiate(room3.PC, new Vector3(-0.09f, 0.6f, -9.90f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
