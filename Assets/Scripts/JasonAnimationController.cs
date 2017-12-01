using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyController
{
	public bool running;
	public bool stop;
	public float timeTillNext;
	public bool disappear;
}


public class JasonAnimationController : MonoBehaviour {
    Animator anim;
    //use these when your changing the animator's peramitors

    //change the animators forward peramitors to make these things happen
    float walk = .5f;
    float run = 1f;
    float idle = 0f;
	float speed;
	public Collider trigger;
    //change the animators side peramitors to make these happen
    float turnLeft = -1f;
    float turnRight = 1f;
	public EnemyController[] setOfInstructions;

    private void Awake()
    {
        anim = GetComponent<Animator>();
		trigger = GetComponentInChildren<Collider>();
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log(other);
			StartCoroutine("Controller");
		}
	}

	IEnumerator Controller()
	{
		for (int i = 0; i < setOfInstructions.Length; i++)
		{
			if (setOfInstructions[i].running)
			{
				speed = run;
			}
			else
			{
				speed = walk;
			}
			if (setOfInstructions[i].stop)
			{
				speed = idle;
			}
			if (setOfInstructions[i].disappear)
			{
				gameObject.SetActive(false);
			}

			anim.SetFloat("Forward", speed);
			yield return new WaitForSeconds(setOfInstructions[i].timeTillNext);
		}
		
	}
}
