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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
