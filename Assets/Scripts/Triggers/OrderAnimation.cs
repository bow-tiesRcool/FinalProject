using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderAnimation : MonoBehaviour {

    public float[] waitBetween;
    public GameObject[] animObject;
    public Animator[] anim;

    public void Start()
    {
        for (int i = 0; i < animObject.Length; i++)
        {
            anim[i] = animObject[i].GetComponent<Animator>();
            Debug.Log(anim[i]);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Player"))
        {
            StartCoroutine("AnimationWait");
        }
    }

    IEnumerator AnimationWait()
    {
        for (int i = 0; i < anim.Length; i++)
        {
            anim[i].SetTrigger("Triggered");
            yield return new WaitForSeconds(waitBetween[i]);
        }
        gameObject.SetActive(false);
    }
}
