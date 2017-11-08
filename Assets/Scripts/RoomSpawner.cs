//using System.Collections;
//using System.Collections.Generic;
//using System.Globalization;
//using System;
//using UnityEngine;


//[System.Serializable]
//public class LevelController
//{
    
//    public GameObject room1;

//    public GameObject room2;

//    public GameObject room3;

    
//}

//public class RoomSpawner : MonoBehaviour {

//    public LevelController[] levels;

//    public float roomLength;

//	// Use this for initialization
//	void Start () {

//        Vector3 positon = transform.position;

//        UnityEngine.Random.InitState(DateTime.Now.Millisecond);
//		foreach (LevelController level in levels)
//        {
//            int rand = (int)UnityEngine.Random.value;
//            int num = rand % 3;

//            if(num == 0)
//            {
//                Instantiate(level.room1, positon, Quaternion.identity);
//            }
//            else if(num == 1)
//            {
//                Instantiate(level.room2, positon, Quaternion.identity);
//            }
//            else if(num == 3)
//            {
//                Instantiate(level.room3, positon, Quaternion.identity);
//            }

//            positon += new Vector3(0, 0, roomLength);
//        }
//	}
	
	
//}
