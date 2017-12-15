using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JasonAppears : MonoBehaviour {

	public GameObject jason;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			jason.SetActive(true);
		}
	}
}
