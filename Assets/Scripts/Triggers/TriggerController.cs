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
            anim.SetTrigger("Triggered");
            gameObject.SetActive(false);
        }
    }
}
