using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour {

    public GameObject animObject;
    public Animator anim;

    private void Start()
    {
        anim = animObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Player"))
        {
			StartCoroutine("Timer");
        }
    }

	IEnumerator Timer()
	{
		anim.SetTrigger("Triggered");
		yield return new WaitForSeconds(2);
		gameObject.SetActive(false);
	}
}
