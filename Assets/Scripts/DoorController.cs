using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

    public float raycastDist = 2f;

    bool doorOpen = false;
    bool doorOpenIn = false;

    Animator lastanim;
    bool animationPlayed = false;

    float timer = 0;

    public float waitTime = 3f;

    public string DoorTag = "Door";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Raycaster();
	}

    void Raycaster()
    {
        if (animationPlayed)
        {
            if(timer >= waitTime)
            {
                animationPlayed = false;
                timer = 0;
            }
            else
            {
                timer += Time.deltaTime;
                return;
            }
        }

        if (doorOpen)
        {
            if (doorOpenIn)
            {
                lastanim.SetTrigger("DoorCloseInOut");
                doorOpen = false;
            }
            if (!doorOpenIn)
            {
                lastanim.SetTrigger("DoorCloseOutIn");
                doorOpen = false;
            }
        }

        Ray r = new Ray(transform.position, transform.forward);
        RaycastHit hitDoor;
        if (Physics.Raycast(r, out hitDoor, raycastDist))
        {
            if(hitDoor.collider.gameObject.tag == DoorTag)
            {
                lastanim = hitDoor.collider.gameObject.GetComponent<Animator>();
                if (!doorOpen)
                {
                    float dot = Vector3.Dot(hitDoor.normal, -hitDoor.collider.transform.right);
                    Debug.Log(dot);
                    if (dot > 0)
                    {
                        hitDoor.collider.gameObject.GetComponent<Animator>().SetTrigger("DoorOpenIn");
                        doorOpen = true;
                        animationPlayed = true;
                        doorOpenIn = true;
                        Debug.Log("Raycast hit front of door");
                    }else if(dot < 0)
                    {
                        hitDoor.collider.gameObject.GetComponent<Animator>().SetTrigger("DoorOpenOut");
                        doorOpen = true;
                        animationPlayed = true;
                        doorOpenIn = false;
                        Debug.Log("Raycast Back front of door");
                    }
                }
            }
        }
        
    }
}
