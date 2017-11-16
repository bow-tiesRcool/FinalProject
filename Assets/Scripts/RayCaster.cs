using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
	public float raycastDist = 2f;
	public static RayCaster instance;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
	}

	void Update()
	{
		Ray r = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		if (Physics.Raycast(r, out hit, raycastDist))
		{
			if (hit.collider.gameObject.tag == "Door")
			{
				hit.collider.GetComponent<DoorControllerE>().DoorAction();
			}
			if (hit.collider.gameObject.tag == "Enemy")
			{
				Debug.Log("Hit Enemy");
			}
			if (hit.collider.gameObject.tag == "NextRoomDoor")
			{
				Debug.Log("Hit NextRoomDoor");
			}
		}
	}
}