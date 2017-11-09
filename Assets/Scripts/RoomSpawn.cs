using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System;
using UnityEngine;

[System.Serializable]
public class Levels
{
    public GameObject[] room;
}

public class RoomSpawn : MonoBehaviour
{
    public string spawnHere;
    public Levels[] level;
    public GameObject[] Rooms;
    public GameObject spawn;

    private void Start()
    {
        GetRooms();
        SpawnRooms();
    }

    void GetRooms()
    {
        int num;
        for (int i = 0; i < level.Length; i++)
        {
            num = UnityEngine.Random.Range(0, level[i].room.Length);
            Rooms[i] = level[i].room[num];
        }
    }

    void SpawnRooms()
    {
        Instantiate(Rooms[0], spawn.transform.position, Quaternion.identity);
        GameObject spawnPoint;
        for (int i = 1; i < Rooms.Length; i++)
        {
            Debug.Log(Rooms[i - 1].transform.Find(spawnHere).gameObject);
            spawnPoint = Rooms[i - 1].transform.Find(spawnHere).gameObject;
            //spawnPoint = Rooms[i - 1].gameObject.Find(spawnHere);
            Instantiate(Rooms[i], spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
