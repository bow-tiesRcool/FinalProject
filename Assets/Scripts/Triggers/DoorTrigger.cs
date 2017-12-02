using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

	public GameObject door;
	public bool slamTrigger;
	public bool doorTrigger;
	public bool openTrigger;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			if (doorTrigger)
			{
				door.GetComponent<DoorController>().CanOpen();
			}
			if (slamTrigger)
			{
				door.GetComponent<DoorController>().SlamAction();
			}
			if (openTrigger)
			{
				door.GetComponent<DoorController>().DoorAction();
			}
		}
	}
}
