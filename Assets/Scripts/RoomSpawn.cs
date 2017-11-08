using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System;
using UnityEngine;

[System.Serializable]
public class LevelController
{
    public GameObject[] Room;
}

public class RoomSpawn : MonoBehaviour {

    public LevelController[] Level;
}
