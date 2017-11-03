using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

    public float raycastDist = 2f;

    bool doorOpen = false;
    public Animation doorOpenAnimation;
    public Animation doorCloseAnimation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Raycaster();
	}

    void Raycaster()
    {
        Ray r = new Ray(transform.position, transform.forward);
        RaycastHit hitDoor;
        if (Physics.Raycast(r, out hitDoor, raycastDist))
        {
            if(hitDoor.collider.gameObject.tag == "Door")
            {
               if(Vector3.Dot((transform.position.normalized - hitDoor.collider.gameObject.transform.position.normalized), hitDoor.collider.gameObject.transform.forward) > 0)
               {
                    //hit front of door
               }
            }
        }
        
    }
}
