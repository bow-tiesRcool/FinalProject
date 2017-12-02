using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

	public GameObject door;
	Animator anim;

	public AudioSource sound;
	public AudioClip openDoor;
	public AudioClip closeDoor;
	public AudioClip tryOpen;
	public AudioClip slamDoor;

	public bool close = true;

	public bool canOpen = false;

	public bool openItself = false;

	public bool slam = false;

	private void Start()
	{
		anim = door.GetComponent<Animator>();
		sound.clip = tryOpen;
	}

	public void DoorAction()
	{
		if (canOpen && close)
		{
			StartCoroutine("DoorOpen");
		}
	}

	public void SlamAction()
	{
		if (openItself && slam)
		{
			StartCoroutine("SlamDoor");
		}
	}

	public void CanOpen()
	{
		canOpen = true;
	}

	IEnumerator DoorOpen()
	{
		sound.clip = openDoor;
		anim.SetTrigger("Open");
		sound.Play();
		close = false;
		yield return new WaitForSeconds(3);
	}

	IEnumerator CloseDoor()
	{
		sound.clip = closeDoor;
		anim.SetTrigger("CloseDoor");
		yield return new WaitForSeconds(1);
		sound.Play();
		close = true;
	}

	IEnumerator SlamDoor()
	{
		sound.clip = slamDoor;
		anim.SetTrigger("SlamDoor");
		yield return new WaitForSeconds(.5f);
		sound.Play();
		close = true;
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("Player") && !close && !openItself)
		{
			StartCoroutine("CloseDoor");
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player") && !canOpen)
		{
			sound.clip = tryOpen;
			sound.Play();
			anim.SetTrigger("TriedOpen");
		}
	}
}
