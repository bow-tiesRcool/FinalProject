using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JasonAnimationController : MonoBehaviour {
    Animator anim;
    //use these when your changing the animator's peramitors
    
    //change the animators forward peramitors to make these things happen
    float walk = .6f;
    float run = 3f;
    float idle = 0f;

    //change the animators side peramitors to make these happen
    float turnLeft = -1f;
    float turnRight = 1f;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start ()
    {
        anim.SetFloat("Forward", walk);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
