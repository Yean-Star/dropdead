using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public RoomSO room;
    void Start()
    {
        Instantiate(room.floor, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(room.table, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(room.player, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(room._wall, new Vector3(0, 0, 0), Quaternion.identity);

        Instantiate(room.Chair, new Vector3(-1.4f, 1.2f, -9.90f), Quaternion.identity);
        Instantiate(room.Doll, new Vector3(-0.1f, 0.6f, -9.90f), Quaternion.identity);
        Instantiate(room.PC, new Vector3(-0.09f, 0.6f, -9.90f), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
