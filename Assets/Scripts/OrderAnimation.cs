using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderAnimation : MonoBehaviour {

    public static OrderAnimation instance;
    public int waitBetween;
    public GameObject[] animObject;
    public Animator[] anim;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Start()
    {
        for (int i = 0; i < animObject.Length; i++)
        {
            instance.anim[i] = instance.animObject[i].GetComponent<Animator>();
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
            instance.anim[i].SetTrigger("Triggered");
            yield return new WaitForSeconds(waitBetween);
        }
        gameObject.SetActive(false);
    }
}
