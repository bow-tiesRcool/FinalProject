using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System;
using UnityEngine;


[System.Serializable]
public class LevelController
{
    
    public GameObject room1;

    public GameObject room2;

    public GameObject room3;

    
}

public class RoomSpawner : MonoBehaviour {

    //put whatever your tagging you spawnpoints here exactly as you have it in the tags
    [Tooltip("Put whatever your tagging your spawnpoints here exactly as you have it in the tags")]
    public string spawnTag;

    public LevelController[] levels;

	// Use this for initialization
	void Start () {

        Vector3 spawnPositon = transform.position;

        UnityEngine.Random.InitState(DateTime.Now.Millisecond);
		foreach (LevelController level in levels)
        {
            int rand = (int)UnityEngine.Random.value;
            int num = rand % 3;

            if(num == 0)
            {
                GameObject room = Instantiate(level.room1, spawnPositon, Quaternion.identity);
                Transform spawn = null;
                Transform[] spawnCandidates = room.GetComponentsInChildren<Transform>();
                foreach (Transform t in spawnCandidates)
                {
                    if (t.CompareTag(spawnTag))
                    {
                        spawn = t;
                        break;
                    }
                }
                if (spawn != null)
                {
                    spawnPositon = spawn.position;
                }

            }
            else if(num == 1)
            {
                GameObject room = Instantiate(level.room2, spawnPositon, Quaternion.identity);
                Transform spawn = null;
                Transform[] spawnCandidates = room.GetComponentsInChildren<Transform>();
                foreach (Transform t in spawnCandidates)
                {
                    if (t.CompareTag(spawnTag))
                    {
                        spawn = t;
                        break;
                    }
                }
                if (spawn != null)
                {
                    spawnPositon = spawn.position;
                }
            }
            else if(num == 3)
            {
                GameObject room = Instantiate(level.room3, spawnPositon, Quaternion.identity);
                Transform spawn = null;
                Transform[] spawnCandidates = room.GetComponentsInChildren<Transform>();
                foreach (Transform t in spawnCandidates)
                {
                    if (t.CompareTag(spawnTag))
                    {
                        spawn = t;
                        break;
                    }
                }
                if (spawn != null)
                {
                    spawnPositon = spawn.position;
                }

            }

           
        }
	}
}
