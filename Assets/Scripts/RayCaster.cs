using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
	public float raycastDist = 2f;

	void Update()
	{
		Ray r = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		if (Physics.Raycast(r, out hit, raycastDist))
		{
			if (hit.collider.gameObject.tag == "Door")
			{
				hit.collider.GetComponent<DoorController>().DoorAction();
			}
		}
	}
}