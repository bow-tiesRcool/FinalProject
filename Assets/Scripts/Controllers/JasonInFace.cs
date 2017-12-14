using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JasonInFace : MonoBehaviour {

	public Camera playerCamera;
	public GameObject itemObject;

	public void InFace()
	{
		itemObject.transform.position = playerCamera.transform.position + Vector3.forward;
	}
}
