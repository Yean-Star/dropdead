using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Room", menuName = "Rooms/Room1")]
public class RoomSO : ScriptableObject
{
    //public new string name;
    public int phaseIndex;
    public GameObject floor;
    public GameObject table;
    public GameObject player;
    public GameObject _wall;
    public GameObject[] _interract;
}
