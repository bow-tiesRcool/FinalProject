using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDisappearController : MonoBehaviour {

	public GameObject hallway;

	private void OnTriggerEnter(Collider other)
	{
		other.gameObject.CompareTag("Player");
		Destroy(hallway);
	}
}
