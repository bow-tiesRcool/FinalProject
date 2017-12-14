using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JasonInFace : MonoBehaviour {

	public GameObject player;
	public GameObject itemObject;
	public bool pop = false;

	public void InFace()
	{
		pop = true;
		itemObject.transform.position = player.transform.position + Vector3.back + Vector3.down;
	}
}
