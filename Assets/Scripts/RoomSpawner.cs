﻿using System.Collections;
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

        Transform spawnTransform = transform;

        UnityEngine.Random.InitState(DateTime.Now.Millisecond);
		foreach(LevelController level in levels)
        {
            
            int rand = (int)(UnityEngine.Random.value * 3);
            
            int num = rand % 3;

            

            if(num == 0)
            {

                GameObject room = Instantiate(level.room1, spawnTransform.position, level.room1.transform.rotation);
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
                    spawnTransform = spawn;
                }

            }
            else if(num == 1)
            {

                GameObject room = Instantiate(level.room2, spawnTransform.position, level.room2.transform.rotation);
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
                    spawnTransform = spawn;
                }
            }
            else if(num == 2)
            {
                
                GameObject room = Instantiate(level.room3, spawnTransform.position, level.room3.transform.rotation);
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
                    spawnTransform = spawn;
                }

            }

           
        }
	}
}
