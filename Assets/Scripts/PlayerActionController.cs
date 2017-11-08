using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionController : MonoBehaviour {

    public GameObject Light;
    public bool lightOn = true;

	void Start () {

    }
	
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            if (lightOn == true)
            {
                Light.SetActive(false);
                lightOn = false;
            }
            else
            {
                Light.SetActive(true);
                lightOn = true;
            }
        }
    }
}
