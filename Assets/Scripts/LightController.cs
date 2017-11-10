using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {

    public GameObject animObject;
    public Animator anim;
    Light light;


    private void Start()
    {
        anim = animObject.GetComponent<Animator>();
        light = animObject.GetComponentInChildren<Light>();
        StartCoroutine("Flicker");
    }

    private void Update()
    {
        if (light.enabled == true)
        {
            anim.SetBool("LightOn", true);
        }
        else
        {
            anim.SetBool("LightOn", false);
        }
    }

    IEnumerator Flicker()
    {
        while (enabled)
        {
            int num = Random.Range(0, 10);
            if (num == 3)
            {
                anim.SetTrigger("Flicker");
            }
            yield return new WaitForSecondsRealtime(10);
        }
    }
}
